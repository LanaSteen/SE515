using FitZone.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Infrastructure.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly FitZoneDbContext _context;

		public UnitOfWork(FitZoneDbContext context)
		{
			_context = context;
		}

		public int SaveChanges()
		{
			return _context.SaveChanges();
		}
	}
}
