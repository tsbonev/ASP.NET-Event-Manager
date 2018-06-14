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
        [MinLength(4, ErrorMessage = "Event name must be at least 4 symbols")]
        [MaxLength(15, ErrorMessage = "Event name cannot exceed 15 symbols")]
        [RegularExpression("([a-zA-Z0-9_]*$)", ErrorMessage = "Name should contain only alphanumeric")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Location name must be at least 2 symbols")]
        [MaxLength(20, ErrorMessage = "Location name cannot exceed 20 symbols")]
        [RegularExpression("([A-Za-z]+)", ErrorMessage = "Location name should contain only letters")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Start date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End date")]
        public DateTime EndDate { get; set; }

        public EventViewModel(){}

        public EventViewModel(Event e)
        {

            this.ID = e.ID;
            this.Name = e.Name;
            this.Location = e.Location;
            this.StartDate = e.StartDate.ToLocalTime();
            this.EndDate = e.EndDate.ToLocalTime();
        }

    }
}