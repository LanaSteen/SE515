using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.Entities;
using FitZone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Infrastructure.Repositories
{
	public class TrainerRepository : ITrainerRepository
	{

		private readonly FitZoneDbContext _context;
		public TrainerRepository(FitZoneDbContext context)
		{
			_context = context;

		}



		public void AddTrainer(Trainer trainer)
		{
			_context.Trainers.Add(trainer);
			//_context.SaveChanges();
		}

		public void DeleteTrainer(Trainer trainer)
		{
			_context.Trainers.Remove(trainer);
			//_context.SaveChanges();
		}
		public List<Trainer> GetAllTrainers()
		{
			return _context.Trainers.ToList();
		}

		public Trainer GetTrainerById(int Id)
		{
			return _context.Trainers.Find(Id);
		}

		public void UpdateTrainer(Trainer trainer)
		{
			var trainerOld = _context.Trainers.Find(trainer.Id);
			trainerOld.Name = trainer.Name;
			trainerOld.Surname = trainer.Surname;
			
			//_context.SaveChanges();
		}


		public List<Trainer> GetAllTrainersWithMembers()
		{
			return _context.Trainers
				.Include(t => t.Members).ToList();
		}
	}
}
