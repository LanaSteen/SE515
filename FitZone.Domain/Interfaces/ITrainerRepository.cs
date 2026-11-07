using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Domain.Interfaces
{
	public interface ITrainerRepository
	{
		void AddTrainer(Trainer trainer);

		void DeleteTrainer(Trainer trainer);
		List<Trainer> GetAllTrainers();

		Trainer GetTrainerById(int Id);
		void UpdateTrainer(Trainer trainer);





	}
}
