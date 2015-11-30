using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ObservationBoard.Models;
using System.Data.Entity.Migrations;

namespace ObservationBoard.Migrations
{
    public class Configuration : DbMigrationsConfiguration<ObservationBoardEntities>
    {
        protected override void Seed(ObservationBoardEntities context)
        {
            context.ObservationBoards.AddOrUpdate(x => x.Id,
                new ObservationBoard() { Id = 1 });
        }
    }
}