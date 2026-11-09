using AutoMapper;
using FitZone.Application.Exceptions;
using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.DTOs.TrainerDTOs;
using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Services.Implementations
{
	public class TrainerService
	{


		private readonly IUnitOfWork _unitOfWork;
		private readonly ITrainerRepository _trainerRepository;
		private readonly IMapper _mapper;

		private readonly IMemberService _memberService;

		public TrainerService(IUnitOfWork unitOfWork, ITrainerRepository trainerRepository, IMapper mapper, IMemberService memberService)
		{
			_unitOfWork = unitOfWork;
			_trainerRepository = trainerRepository;
			_mapper = mapper;
			_memberService = memberService;
		}


		public void AddTrainer(CreateTrainerDTO trainer)
		{
			if(trainer == null)
			{
				throw new TrainerNullException();
			}

			if(String.IsNullOrWhiteSpace(trainer.Name) || String.IsNullOrWhiteSpace(trainer.Surname))
			{
				throw new ArgumentException("Name and Surname cannot be empty");
			}


			var newTrainer = _mapper.Map<Trainer>(trainer);
			_trainerRepository.AddTrainer(newTrainer);
			_unitOfWork.SaveChanges();
		}

		public void DeleteTrainer(int Id)
		{
			if (Id == 0)
			{
				throw new ArgumentException("Id cannot be 0");
			}
			var trainer = _trainerRepository.GetTrainerById(Id);
			if (trainer == null)
			{
				throw new TrainerNotFoundException();
			}


			var members = _memberService.GetAllMembers();
			var membersOfTrainer = members.FindAll(m => m.TrainerId == Id);
			foreach (var item in membersOfTrainer)
			{
				_memberService.DeleteMember(item.Id);
			}
			_unitOfWork.SaveChanges();

			_trainerRepository.DeleteTrainer(trainer);
			_unitOfWork.SaveChanges();



		}


		public void UpdateTrainer(UpdateTrainerDTO trainer)
		{
			if (trainer == null)
			{
				throw new TrainerNullException();
			}
			if (trainer.Id == 0)
			{
				throw new ArgumentException("Id cannot be 0");
			}
			var updatedTrainer = _mapper.Map<Trainer>(trainer);
			_trainerRepository.UpdateTrainer(updatedTrainer);
			_unitOfWork.SaveChanges();
		}


		public List<TrainerDTO> GetAllTrainers()
		{
			var trainers = _trainerRepository.GetAllTrainers();
			if (trainers == null || trainers.Count == 0)
			{
				throw new ArgumentException("No trainers found");
			}
			var trainersDTO = _mapper.Map<List<TrainerDTO>>(trainers);
			return trainersDTO;
		}
	
	
	    public TrainerDTO GetTrainerById(int Id)
		{
			if (Id == 0)
			{
				throw new ArgumentException("Id cannot be 0");
			}
			var trainer = _trainerRepository.GetTrainerById(Id);
			if (trainer == null)
			{
				throw new TrainerNotFoundException();
			}
			var trainerDTO = _mapper.Map<TrainerDTO>(trainer);
			return trainerDTO;
		}

		public TrainerWithMembersDTO GetTrainerWithMembers(int Id)
		{
			if (Id == 0)
			{
				throw new ArgumentException("Id cannot be 0");
			}
			var trainer = _trainerRepository.GetAllTrainersWithMembers().Find(t => t.Id == Id);
			if (trainer == null)
			{
				throw new TrainerNotFoundException();
			}
			var trainerWithMembersDTO = _mapper.Map<TrainerWithMembersDTO>(trainer);
			return trainerWithMembersDTO;
		}
	}
}
