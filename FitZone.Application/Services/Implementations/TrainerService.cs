using FitZone.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Services.Implementations
{
	public class TrainerService
	{


		private readonly IUnitOfWork _unitOfWork;
		private readonly ITrainerRepository _trainerRepository;

		public TrainerService(IUnitOfWork unitOfWork, ITrainerRepository trainerRepository)
		{
			_unitOfWork = unitOfWork;
			_trainerRepository = trainerRepository;
		}






	}
}
