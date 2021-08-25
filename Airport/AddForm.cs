using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.BLL;
using Department.DAL;
using Entities;

namespace Airport
{
    public partial class AddForm : Form
    {

        public AddForm(string dataGridView, string action)
        {
            InitializeComponent();
            SetCorrectComponentsAndInfo(dataGridView, action);
        }

        private void SetCorrectComponentsAndInfo(string dataGridView, string action)
        {
            if (action == "Add")
            {
                this.Text = "Добавление записи";
                buttonOK.Text = "Добавить";
            }
            else if (action == "Edit")
            {
                this.Text = "Изменение записи";
                buttonOK.Text = "Изменить";
            }

            if (dataGridView == "Passengers")
            {
                panelPassengers.Visible = true;
            }
            else if (dataGridView == "Documents")
            {
                panelDocuments.Visible = true;
                //заполнение combobox'ов
                PassengersBL passengers = new PassengersBL(new PassengersSQLDAO());
                List<Passengers> passengersList = passengers.GetPassengers().ToList();
                foreach (Passengers passenger in passengersList)
                    cbOwnerId.Items.Add(passenger.Id);
                CountriesBL countries = new CountriesBL(new CountriesSQLDAO());
                List<Countries> countriesList = countries.GetCountries().ToList();
                foreach (Countries country in countriesList)
                    cbDocumentCountry.Items.Add(country.Country);
            }
            else if (dataGridView == "Tickets")
            {
                panelTickets.Visible = true;
                FlightsBL flights = new FlightsBL(new FlightsSQLDAO());
                List<Flights> flightsList = flights.GetFlights().ToList();
                foreach (Flights flight in flightsList)
                    cbTicketFlight.Items.Add(flight.FlightNumber);
                DocumentsBL documents = new DocumentsBL(new DocumentsSQLDAO());
                List<Documents> documentsList = documents.GetDocuments().ToList();
                foreach (Documents document in documentsList)
                    cbTicketDocument.Items.Add(document.DocumentNumber);
            }
            else if (dataGridView == "Flights")
            {
                panelFlights.Visible = true;
                AirplanesBL airplanes = new AirplanesBL(new AirplanesSQLDAO());
                List<Airplanes> airplanesList = airplanes.GetAirplanes().ToList();
                foreach (Airplanes airplane in airplanesList)
                    cbFlightAirplane.Items.Add(airplane.AirplaneNumber);
                AirportsBL airports = new AirportsBL(new AirportsSQLDAO());
                List<Airports> airportsList = airports.GetAirports().ToList();
                foreach (Airports airport in airportsList)
                {
                    cbFlightAirportD.Items.Add(airport.Code);
                    cbFlightAirportA.Items.Add(airport.Code);
                }
            }
            else if (dataGridView == "Airplanes")
            {
                panelAirplanes.Visible = true;
                AirlinesBL airlines = new AirlinesBL(new AirlinesSQLDAO());
                List<Airlines> airlinesList = airlines.GetAirlines().ToList();
                foreach (Airlines airline in airlinesList)
                    cbAirplaneAirlines.Items.Add(airline.Name);
            }
            else if (dataGridView == "Airlines")
            {
                panelAirlines.Visible = true;
                CountriesBL countries = new CountriesBL(new CountriesSQLDAO());
                List<Countries> countriesList = countries.GetCountries().ToList();
                foreach (Countries country in countriesList)
                    cbAirlinesCountry.Items.Add(country.Country);
            }
            else if (dataGridView == "Countries")
            {
                panelCountries.Visible = true;
            }
            else if (dataGridView == "Cities")
            {
                panelCity.Visible = true;
                CountriesBL countries = new CountriesBL(new CountriesSQLDAO());
                List<Countries> countriesList = countries.GetCountries().ToList();
                foreach (Countries country in countriesList)
                    cbCityCountry.Items.Add(country.Country);
            }
            else if (dataGridView == "Airports")
            {
                panelAirports.Visible = true;
                CitiesBL cities = new CitiesBL(new CitiesSQLDAO());
                List<Cities> citiesList = cities.GetCities().ToList();
                foreach (Cities city in citiesList)
                    cbAirportCity.Items.Add(city.Id);
            }
        }

        //ввод только цифр в поле цена у билета
        private void tbTicketCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbAirplaneSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbPassengerSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number))
            {
                e.Handled = true;
            }
        }
    }
}