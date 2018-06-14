using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataAccess;

namespace EventManager.Models
{

    public class EventsViewModel
    {

        public List<EventViewModel> eventsList;

        public EventsViewModel(List<Event> list)
        {
            this.eventsList = new List<EventViewModel>();

            foreach (Event e in list)
            {
                eventsList.Add(new EventViewModel(e));
            }
            
        }

    }

    public class EventViewModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public EventViewModel(){}

        public EventViewModel(Event e)
        {
            this.ID = e.ID;
            this.Name = e.Name;
            this.Location = e.Location;
            this.StartDate = e.StartDate;
            this.EndDate = e.EndDate;
        }

    }
}