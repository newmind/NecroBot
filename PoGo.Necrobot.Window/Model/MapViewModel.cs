﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoGo.NecroBot.Logic.Event;

namespace PoGo.Necrobot.Window.Model
{
    public class MapViewModel  : ViewModelBase
    {
        private double lat;
        private double lng;

        public MapViewModel()
        {
            this.NearbyPokemons = new ObservableCollection<MapPokemonViewModel>();
        }
        public ObservableCollection<MapPokemonViewModel> NearbyPokemons { get; set; }

        public double CurrentLatitude { get { return lat; }
            set
            {
                lat = value;
                RaisePropertyChanged("CurrentLatitude");
            }
        }

        public double CurrentLongitude
        {
            get { return lng; }
            set
            {
                lng = value;
                RaisePropertyChanged("CurrentLongitude");
            }
        }

        internal void OnEncounterEvent(EncounteredEvent encounteredEvent)
        {
            throw new NotImplementedException();
        }
    }
}
