using CalendarioComGoogle.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace CalendarioComGoogle.Controllers
{
	public class HomeController : Controller
	{
		private readonly ServicoGoogleCalendarAPI _servicoGoogleCalendarAPI;

		public HomeController(ServicoGoogleCalendarAPI servicoGoogleCalendarAPI)
		{
			_servicoGoogleCalendarAPI = servicoGoogleCalendarAPI;
		}

		[HttpGet]
		public ActionResult Index()
		{
			return View(new EventViewModel());
		}

		public JsonResult ConsultarAgendamentos()
		{
			var viewModel = new EventViewModel();
			var events = new List<EventViewModel>();
			var listaDeEventos = _servicoGoogleCalendarAPI.ConsultarAgendamentos();
			var listaDeFeriados = _servicoGoogleCalendarAPI.ConsultarFeriados();

			foreach(var agendamento in listaDeEventos)
			{
				var start = agendamento.Start.DateTime.Value;
				var end = agendamento.End.DateTime.Value;

				events.Add(new EventViewModel()
				{
					id = agendamento.Id,
					title = "Event " + agendamento.Summary,
					start = start.ToString(CultureInfo.InvariantCulture),
					end = end.ToString(CultureInfo.InvariantCulture),
					allDay = false
				});
			}

			foreach(var agendamento in listaDeFeriados)
			{
				var start = agendamento.Start.Date;
				var end = agendamento.End.Date;

				events.Add(new EventViewModel()
				{
					id = agendamento.Id,
					title = "Event " + agendamento.Summary,
					start = start.ToString(CultureInfo.InvariantCulture),
					end = end.ToString(CultureInfo.InvariantCulture),
					allDay = true
				});
			}

			return Json(events.ToArray());
		}

		public void CriarAgendamentos(String data)
		{
			_servicoGoogleCalendarAPI.CriarAgendamentos(data);

			ConsultarAgendamentos();
		}

		public void DeletarAgendamentos(String data)
		{
			_servicoGoogleCalendarAPI.DeletarAgendamento(data);

			ConsultarAgendamentos();
		}
	}
}
