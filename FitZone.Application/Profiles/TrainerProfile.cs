using AutoMapper;
using FitZone.Domain.Models.DTOs.TrainerDTOs;
using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Profiles
{
	public class TrainerProfile :  Profile
	{
		public TrainerProfile()
		{

			CreateMap<Trainer, TrainerDTO>().ReverseMap();
			CreateMap<CreateTrainerDTO, Trainer>();
			CreateMap<Trainer, UpdateTrainerDTO>();
			CreateMap<UpdateTrainerDTO, Trainer>();
			CreateMap<Trainer, CreateTrainerDTO	>();
		}

	}
}
