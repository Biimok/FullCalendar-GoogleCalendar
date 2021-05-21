using CalendarioComGoogle.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace CalendarioComGoogle
{
    public class ServicoGoogleCalendarAPI
    {
        private static UserCredential _credenciais;

        private static CalendarService _servico;

        public ICollection<Event> ConsultarAgendamentos()
        {
            AutorizarAcesso();

            var requisicao = _servico.Events.List("primary");

            requisicao.TimeMin = DateTime.Now.AddDays(-30);
            requisicao.ShowDeleted = false;
            requisicao.SingleEvents = true;
            requisicao.MaxResults = 10;
            requisicao.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            var resposta = requisicao.Execute();

            if (resposta.Items == null || !resposta.Items.Any())
            {
                return new List<Event>();
            }

            return resposta.Items;
        }

        public ICollection<Event> ConsultarFeriados()
        {
            AutorizarAcesso();

            var requisicao = _servico.Events.List("brazilian__pt-br@holiday.calendar.google.com");

            requisicao.TimeMin = DateTime.Now.AddDays(-30);
            requisicao.ShowDeleted = false;
            requisicao.SingleEvents = true;
            requisicao.MaxResults = 10;
            requisicao.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            var resposta = requisicao.Execute();

            if (resposta.Items == null || !resposta.Items.Any())
            {
                return new List<Event>();
            }

            return resposta.Items;
        }

        public void CriarAgendamentos(String data)
        {
            AutorizarAcesso();

            var requisicao = _servico.Events.Insert(new Event
            {
                Summary = $"Teste {DateTime.Parse(data)}",
                Start = new EventDateTime() { DateTime = DateTime.Parse(data) },
                End = new EventDateTime() { DateTime = DateTime.Parse(data).AddDays(2) },
            }, "primary");

            requisicao.Execute();
        }

        public void DeletarAgendamento(string id)
        {
            AutorizarAcesso();

            var requisicao = _servico.Events.Delete("primary", id);

            requisicao.Execute();
        }

        private void AutorizarAcesso()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                _credenciais = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new string[] {
                        CalendarService.Scope.Calendar,
                        CalendarService.Scope.CalendarReadonly,
                        CalendarService.Scope.CalendarEvents,
                        CalendarService.Scope.CalendarEventsReadonly
                    },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true)).Result;
            }

            _servico = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = _credenciais,
                ApplicationName = "teste",
            });
        }
    }
}
