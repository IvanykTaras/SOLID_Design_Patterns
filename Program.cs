using SOLID_Design_Patterns.Behavioral.ChainOfResponsibility;
using SOLID_Design_Patterns.Behavioral.Mediator;
using SOLID_Design_Patterns.Behavioral.TemplateMethod;
using SOLID_Design_Patterns.Creational.AbstractFactory;
using SOLID_Design_Patterns.Creational.Builder;
using SOLID_Design_Patterns.Creational.Factory;
using System;
using System.Linq;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args){


            /// 
            /// Builder 
            /// 

            /*
            var builder = new InvoiceBuilder();
            var director = new Director(builder);

            director.MakeInvoiceForEdward();
            director.MakeInvoiceForTaras();
            ShowProperties(builder.Result());
             */



            /// 
            /// Abstract Factory 
            /// 

            /*
            var windows = new WindowsFactory();
            var mac = new MacFactory(); 
            var uiApplication = new Aplication(windows);
            uiApplication.RenderUI();
            */



            /// 
            /// Prototype 
            /// 

            /*var circle = new Circle();
            var shallowCircle = (Circle)circle.Clone();
            circle.properties.Add("init");
            shallowCircle.properties.Add("new");

            Console.WriteLine(string.Join(", ",circle.properties) + " === " + string.Join(", ", shallowCircle.properties));*/



            /// 
            /// Mediator 
            /// 

            /*
            Button button = new Button();
            Checkbox checkbox = new Checkbox();
            new RegisterClientView(checkbox, button);
            checkbox.Select();
            button.Click();*/




            /// 
            /// Chain of responsibiltiy
            /// 

            /*
            var requestContext = new RequestContext() { 
                request = new Request() {
                    EntityId = 101,
                    UserId = 14,
                    UserRole = "User"
                },
                response = new Response() { }
            };

            var requestContextErr = new RequestContext()
            {
                request = new Request()
                {
                    EntityId = 102,
                    UserId = 10,
                    UserRole = "User"
                },
                response = new Response() { }
            };

            var resultHandler = new ResultHandler(null);
            var validationHandler = new ValidationHandler(resultHandler);
            var authorizationHandler = new AuthorizationHandler(validationHandler);

            authorizationHandler.Handle(requestContextErr);
            Console.WriteLine($"IsSuccess:{requestContextErr.response.IsSuccessesfull}");
            Console.WriteLine($"Message:{requestContextErr.response.Message}");
            Console.WriteLine($"Data:{requestContextErr.response.Data}");

            Console.WriteLine("----");

            authorizationHandler.Handle(requestContext);
            Console.WriteLine($"IsSuccess:{requestContext.response.IsSuccessesfull}");
            Console.WriteLine($"Message:{requestContext.response.Message}");
            Console.WriteLine($"Data:{requestContext.response.Data}");*/



            ///
            /// Template Method
            ///

            /*var pdfGenerator = new PdfGenerator();
            var csvGenerator = new CsvGenerator();

            Console.WriteLine("*** PDF ***");
            pdfGenerator.GenerateReprot();

            Console.WriteLine("*** CSV ***");
            csvGenerator.GenerateReprot();*/



        }


        public static void ShowProperties(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var prop in properties)
            {
                var propValue = prop.GetValue(obj, null);
                Console.WriteLine($"{prop.Name}: {propValue}");
            }
        }
    }


    
}