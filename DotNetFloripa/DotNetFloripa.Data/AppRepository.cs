﻿using DotNetFloripa.Model;
using DotNetFloripa.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFloripa.Data
{
    public class AppRepository : IAppRepository
    {
        public AppRepository()
        {
            Events = new[]{
                new Event {
                    Id = 1,
                    Slug = "dotnetfloripa-fevereiro",
                    Description = "O grupo DotNetFloripa está voltando a ativa e já temos um novo evento marcado!",
                    Start = new DateTime(2014,2,19,19,00,0),
                    End = new DateTime(2014,2,19,21,30,0),
                    EventickId = 4846,
                    EventickUrl = "http://www.eventick.com.br/dotnetfloripa-fevereiro",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[]{"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Fevereiro",
                    Talks = new[]{ 
                        new Talk { 
                            Description = "NancyFX é um framework HTTP super leve que serve de alternativa para o ASP.NET MVC ou ASP.NET Web API. Por que precisamos de uma alternativa? Quais os benefícios que isso traz e como introduzir o NancyFX em um app já existente? Venha conferir!",
                            Start = new DateTime(2014,2,19,19,30,0),
                            End = new DateTime(2014,2,19,20,15,0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Conheça o NancyFX!"
                        },new Talk { 
                            Start = new DateTime(2014,2,19,20,15,0),
                            End = new DateTime(2014,2,19,20,30,0),
                            Title = "coffee-break",
                            Description = "Sim! Agora temos coffee-break com deliciosos salgadinhos!"
                        },new Talk { 
                            Description = "Todos nós amamos o Nuget. É até difícil lembrar o quanto era cruel gerenciar nossas dependências de projetos manualmente. Nesta palestra damos um passo a mais: vamos aprender como criar nossos próprios pacotes, integrá-los com builds automatizados e descobrir como sua empresa pode tirar o máximo desta tecnologia.",
                            Start = new DateTime(2014,2,19,20,30,0),
                            End = new DateTime(2014,2,19,21,30,0),
                            Speaker = "André Carlucci",
                            Title = "Aproveite ao máximo o Nuget"
                        }
                    }
                },
                new Event {
                    Id = 2,
                    Slug = "dotnetfloripa-marco",
                    Description = "Mais um evento do DotNetFloripa!",
                    Start = new DateTime(2014,3,19,19,00,0),
                    End = new DateTime(2014,3,19,21,30,0),
                    EventickId = 5103,
                    EventickUrl = "http://www.eventick.com.br/dotnetfloripa-marco",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[]{"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Março",
                    Talks = new[]{ 
                        new Talk { 
                            Description = "O TypeScript é uma extensão da linguagem JavaScript que adiciona 'tipagem' e mais uma série de facilidades ao programador e que é \"compilada\" para JavaScript puro, portanto compatível com qualquer código JavaScript existente (por exemplo, jQuery). Nessa palestra você irá aprender por que vale a pena aprender e usar TypeScript, e como utilizá-la da melhor forma possível.",
                            Start = new DateTime(2014,3,19,19,30,0),
                            End = new DateTime(2014,3,19,20,15,0),
                            Speaker = "Bruno Michels",
                            Title = "Introdução ao TypeScript"
                        },new Talk { 
                            Start = new DateTime(2014,3,19,20,15,0),
                            End = new DateTime(2014,3,19,20,30,0),
                            Title = "coffee-break",
                            Description = "Sim! Agora temos coffee-break com deliciosos salgadinhos!"
                        },new Talk { 
                            Description = "Aprenda como mapear stored procedures de Insert, Delete e Update baseado diretamente na classe. Veja ainda como renomear uma SP, como inserir log no código para rastrear as execuções num projeto ASP.NET MVC 5 com chamadas assíncronas. Nesta palestra, para completar o entendimento, Renato abordará o uso de Migrations e Code First, ou seja, crie as classes no projeto e deixe que o Visual Studio crie o banco de dados em tempo de execução.",
                            Start = new DateTime(2014,3,19,20,30,0),
                            End = new DateTime(2014,3,19,21,30,0),
                            Speaker = "Renato Haddad - Microsoft Most Valuable Professional (MVP)",
                            Title = "Como mapear Stored Procedures no Entity Framework 6?"
                        }
                    }
                }
            };

            Companies = new[] {
                new Company {
                    Name = "Way2 Techonology",
                    Description = "A Way2 desenvolve softwares e serviços para telemedição e gestão de dados de medição de energia. Sediada em Florianópolis, Santa Catarina, a empresa possui uma equipe multidisciplinar especializada no atendimento às demandas de empresas do setor elétrico, como geradoras, transmissoras, distribuidoras e comercializadoras.",
                    Site = "http://way2.com.br",
                    Address = "Rodovia SC 401, Km 04, Espaço Primavera Garden - Bloco B",
                    LogoUrl = "http://i.imgur.com/Slsbsu1.png"
                },
                new Company {
                    Name = "Bravi Software",
                    Description = "A Bravi Software é uma empresa que desenvolve soluções e tecnologia para o mercado da educação.",
                    Site = "http://bravisoftware.com/",
                    Address = "Rodovia SC 401, n° 8600 - Sala 4, bloco 08",
                    LogoUrl = "http://bravisoftware.com/img/bg-logo.png"
                }
            };
        }
        public Event[] Events { get; private set; }
        public Company[] Companies { get; set; }
        public IQueryable<Event> GetEvents()
        {
            return Events.AsQueryable();
        }
        public Event GetEventBySlug(string slug)
        {
            return Events.FirstOrDefault(e => e.Slug.Equals(slug, StringComparison.InvariantCultureIgnoreCase));
        }
        public IQueryable<Company> GetCompanies()
        {
            return Companies.AsQueryable();
        }
    }
}
