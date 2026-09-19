using School.Domain.Interfaces;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Implementations
{
	public class UserService
	{
		//DI
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository) 
		{
			_userRepository = userRepository;
		}


		public async Task<List<User>> GetUsers()
		{
		    var users =	_userRepository.GetUsers();
			if(users == null)
			{
				throw new Exception("No users found");
			}


			return await _userRepository.GetUsers();
		}

		public async Task<User> GetUserById(int id)
		{
			var user = await _userRepository.GetUserById(id);
			if (user == null)
			{
				throw new Exception("User not found");
			}
			return user;
		}

		public async Task<User> GetUserByUsername(string name) 
		{ 
		  if(string.IsNullOrEmpty(name))
			{
				throw new Exception("Name is null or empty");
			}
			return await _userRepository.GetUserByUsername(name);
		}


		public async Task AddUser(User user)
		{
			if (user == null)
			{
				throw new Exception("User is null");
			}

			List<User> users = await _userRepository.GetUsers();

			int nextId = users.Any()
				? users.Max(u => u.Id) + 1
				: 1;

			user.Id = nextId;

			user.VerificationCode = GenerateVerificationCode();


			await _userRepository.AddUser(user);




EmailService.SendEmail(
	user.Email,
	"Verification Code",
	$@"<!DOCTYPE html>
<html>
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Email Verification</title>
</head>

<body style=""margin:0; padding:0; background-color:#f4f4f7; font-family:Arial, Helvetica, sans-serif;"">

    <table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""
           style=""background-color:#f4f4f7; padding:40px 0;"">
        <tr>
            <td align=""center"">

                <table width=""600"" cellpadding=""0"" cellspacing=""0"" border=""0""
                       style=""background-color:#ffffff; border-radius:10px; padding:40px;"">

                    <tr>
                        <td align=""center"">

                            <h1 style=""color:#333333; margin:0 0 20px 0;"">
                                Verify Your Email
                            </h1>

                            <p style=""color:#555555; font-size:16px; line-height:1.6;"">
                                Thank you for registering.
                                Please use the verification code below to verify your email address.
                            </p>

                            <div style=""
                                background-color:#f0f0f5;
                                border-radius:8px;
                                padding:20px;
                                margin:30px 0;
                                text-align:center;"">

                                <span style=""
                                    font-size:32px;
                                    font-weight:bold;
                                    letter-spacing:8px;
                                    color:#333333;"">
                                    {user.VerificationCode}
                                </span>

                            </div>

                            <p style=""color:#777777; font-size:14px;"">
                                This code will expire in <strong>10 minutes</strong>.
                            </p>

                            <p style=""color:#777777; font-size:14px; line-height:1.5;"">
                                If you did not request this verification code,
                                you can safely ignore this email.
                            </p>

                            <hr style=""border:0; border-top:1px solid #eeeeee; margin:30px 0;"">

                            <p style=""color:#999999; font-size:12px;"">
                                © 2026 Your Company. All rights reserved.
                            </p>

                        </td>
                    </tr>

                </table>

            </td>
        </tr>
    </table>

</body>
</html>"
);


				///"Verification Code", $"Your verification code is: {user.VerificationCode}");  // TODO HTML FORMAT


		}



		public async Task DeleteUser(int id)
		{  
			if(id < 0)
			{
				throw new Exception("Id is less than or equal to 0");
			}
			await _userRepository.DeleteUser(id); 
		
		}

		public async Task UpdateUser(User user)
		{
			if (user == null)
			{
				throw new Exception("User is null");
			}
		  await _userRepository.UpdateUser(user);
		}




		private string GenerateVerificationCode()
		{ 
		   Random random = new Random();
		   string code =  random.Next(1000, 9999).ToString();
		   return code;
		}
	}
}
