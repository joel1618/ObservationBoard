using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

using ObservationBoard.Services;
using ObservationBoard.Services.Interfaces;
using ObservationBoard.API;
using System.Web.Http;

namespace ObservationBoard
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            container.RegisterType<IObservationBoardService, ObservationBoardService>();
            container.RegisterType<ObservationBoardController>();


            return container;
        }
    }
}
