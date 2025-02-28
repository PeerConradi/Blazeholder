using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazeholder
{
	internal interface IBlazeholderState
	{
		Task TaskElement { get; }

		Task SetTask(System.Threading.Tasks.Task task);
	}
}
