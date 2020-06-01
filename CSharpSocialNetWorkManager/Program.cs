using CSharpSocialNetWorkManager.Models;
using CSharpSocialNetWorkManager.Utilities.Log;
using System;
using System.Linq;

namespace CSharpSocialNetWorkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new AppManager(new LogJson());

            Console.WriteLine($"Bienvenido a {app.AppTitle}");

            while (true)
            {

                Console.WriteLine("Redes sociales disponibles");

                foreach (var item in app.SocialNetworks.Concat(app.SocialNetWorkWithGroups))
                {
                    Console.WriteLine($"{item.Name}");
                }

                Console.WriteLine("Escriba el nombre de la red social a la que desee ingresar");

                string socialNetworkName = Console.ReadLine();

                var SocialNetworkSelected = app.SocialNetworks.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName);

                Console.Write(app.GetSocialNetWorkInformation(SocialNetworkSelected));

                var SocialNetworkwithGroupsSelected = app.SocialNetWorkWithGroups.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName);

                Console.Write(app.GetSocialNetWorkInformation(SocialNetworkwithGroupsSelected));

                Console.WriteLine("");
                Console.WriteLine("1=Agregar nuevo usuario, 2=Para las estadisticas");

                var optionSelected = int.Parse(Console.ReadLine());

                switch (optionSelected)
                {
                    case 1:
                        {
                            Console.WriteLine("Por favor ingrese su Nombre");
                            string name = Console.ReadLine();
                            Console.WriteLine("Por favor ingrese su Correo");
                            string email = Console.ReadLine();
                            Console.WriteLine("Por favor ingrese su Edad");
                            short age = short.Parse(Console.ReadLine());

                            var user = new User();
                            user.Name = name;
                            user.Email = email;
                            user.Age = age;

                            if (user.IsValid())
                            {
                                Console.WriteLine("Sus datos son:");
                                Console.WriteLine($"Nombre: { user.Name}");
                                Console.WriteLine($"Correo: { user.Email}");
                                Console.WriteLine($"Edad: { user.Age}");
                                Console.WriteLine($"Estado activo: { user.IsActive}");
                            }
                            else
                            {
                                Console.WriteLine("Los datos del usuario no son válidos");
                            }

                            if (SocialNetworkSelected!=null)
                            {
                                int indexElement = app.SocialNetworks.IndexOf(SocialNetworkSelected);
                                app.SocialNetworks[indexElement].Users.Add(user);
                            }
                            if (SocialNetworkwithGroupsSelected != null)
                            {
                                int indexElement = app.SocialNetWorkWithGroups.IndexOf(SocialNetworkwithGroupsSelected);
                                app.SocialNetWorkWithGroups[indexElement].Users.Add(user);
                            }
                            
                            Console.WriteLine();

                        }
                        break;
                    case 2:
                        if (SocialNetworkSelected != null)
                           Console.WriteLine(app.GetSocialNetWorkStats(SocialNetworkSelected));
                        if(SocialNetworkwithGroupsSelected!=null)
                            Console.WriteLine(app.GetSocialNetWorkStats(SocialNetworkwithGroupsSelected));
                        break;
                }

             
            }


        }
    }
}
