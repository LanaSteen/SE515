using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Domain.Interfaces
{
	public interface IUnitOfWork
	{
		int SaveChanges();
	}
}
