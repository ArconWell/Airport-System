using Department.BLL;
using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class MainForm : Form
    {
        public PassengersBL passengers = new PassengersBL(new PassengersSQLDAO());
        public DocumentsBL documents = new DocumentsBL(new DocumentsSQLDAO());
        public TicketsBL tickets = new TicketsBL(new TicketsSQLDAO());
        public FlightsBL flights = new FlightsBL(new FlightsSQLDAO());
        public AirplanesBL airplanes = new AirplanesBL(new AirplanesSQLDAO());
        public AirlinesBL airlines = new AirlinesBL(new AirlinesSQLDAO());
        public CountriesBL countries = new CountriesBL(new CountriesSQLDAO());
        public CitiesBL cities = new CitiesBL(new CitiesSQLDAO());
        public AirportsBL airports = new AirportsBL(new AirportsSQLDAO());

        public MainForm()
        {
            InitializeComponent();
            FillPassengersDGV(passengers.GetPassengers().ToList());
        }

        private void FillPassengersDGV(List<Passengers> dataList)
        {
            dgvPassengers.RowCount = dataList.Count;
            for (int i = 0; i < dgvPassengers.RowCount; i++)
            {
                dgvPassengers[0, i].Value = dataList[i].Id;
                dgvPassengers[1, i].Value = dataList[i].Surname;
                dgvPassengers[2, i].Value = dataList[i].Name;
                dgvPassengers[3, i].Value = dataList[i].Patronymic;
                dgvPassengers[4, i].Value = dataList[i].DateOfBirth.ToShortDateString();
            }
        }

        private void FillDocumentsDGV(List<Documents> dataList)
        {
            dgvDocuments.RowCount = dataList.Count;
            for (int i = 0; i < dgvDocuments.RowCount; i++)
            {
                dgvDocuments[0, i].Value = dataList[i].DocumentNumber;
                dgvDocuments[1, i].Value = dataList[i].DocumentType;
                dgvDocuments[2, i].Value = dataList[i].Country;
                dgvDocuments[3, i].Value = dataList[i].OwnerId;
            }
        }

        private void FillTicketsDGV(List<Tickets> dataList)
        {
            dgvTickets.RowCount = dataList.Count;
            for (int i = 0; i < dgvTickets.RowCount; i++)
            {
                dgvTickets[0, i].Value = dataList[i].TicketNumber;
                dgvTickets[1, i].Value = dataList[i].Document;
                dgvTickets[2, i].Value = dataList[i].Flight;
                dgvTickets[3, i].Value = dataList[i].SeatNumber;
                dgvTickets[4, i].Value = dataList[i].Cost;
            }
        }

        private void FillFlightsDGV(List<Flights> dataList)
        {
            dgvFlights.RowCount = dataList.Count;
            for (int i = 0; i < dgvFlights.RowCount; i++)
            {
                dgvFlights[0, i].Value = dataList[i].FlightNumber;
                dgvFlights[1, i].Value = dataList[i].AirplaneNumber;
                dgvFlights[2, i].Value = dataList[i].DepartureAirport;
                dgvFlights[3, i].Value = dataList[i].ArrivalAirport;
                dgvFlights[4, i].Value = dataList[i].DepartureDateTime;
                dgvFlights[5, i].Value = dataList[i].ArrivalDateTime;
            }
        }

        private void FillAirplanesDGV(List<Airplanes> dataList)
        {
            dgvAirplanes.RowCount = dataList.Count;
            for (int i = 0; i < dgvAirplanes.RowCount; i++)
            {
                dgvAirplanes[0, i].Value = dataList[i].AirplaneNumber;
                dgvAirplanes[1, i].Value = dataList[i].AirplaneName;
                dgvAirplanes[2, i].Value = dataList[i].Airline;
                dgvAirplanes[3, i].Value = dataList[i].SeatsCount;
            }
        }

        private void FillAirlinesDGV(List<Airlines> dataList)
        {
            dgvAirlines.RowCount = dataList.Count;
            for (int i = 0; i < dgvAirlines.RowCount; i++)
            {
                dgvAirlines[0, i].Value = dataList[i].Name;
                dgvAirlines[1, i].Value = dataList[i].Country;
            }
        }

        private void FillCountriesDGV(List<Countries> dataList)
        {
            dgvCountries.RowCount = dataList.Count;
            for (int i = 0; i < dgvCountries.RowCount; i++)
            {
                dgvCountries[0, i].Value = dataList[i].Country;
            }
        }

        private void FillCitiesDGV(List<Cities> dataList)
        {
            dgvCities.RowCount = dataList.Count;
            for (int i = 0; i < dgvCities.RowCount; i++)
            {
                dgvCities[0, i].Value = dataList[i].Id;
                dgvCities[1, i].Value = dataList[i].City;
                dgvCities[2, i].Value = dataList[i].Country;
            }
        }

        private void FillAirportsDGV(List<Airports> dataList)
        {
            dgvAirports.RowCount = dataList.Count;
            for (int i = 0; i < dgvAirports.RowCount; i++)
            {
                dgvAirports[0, i].Value = dataList[i].Code;
                dgvAirports[1, i].Value = dataList[i].AirportName;
                dgvAirports[2, i].Value = dataList[i].CityId;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    FillPassengersDGV(passengers.GetPassengers().ToList());
                    break;
                case 1:
                    FillDocumentsDGV(documents.GetDocuments().ToList());
                    break;
                case 2:
                    FillTicketsDGV(tickets.GetTickets().ToList());
                    break;
                case 3:
                    FillFlightsDGV(flights.GetFlights().ToList());
                    break;
                case 4:
                    FillAirplanesDGV(airplanes.GetAirplanes().ToList());
                    break;
                case 5:
                    FillAirlinesDGV(airlines.GetAirlines().ToList());
                    break;
                case 6:
                    FillCountriesDGV(countries.GetCountries().ToList());
                    break;
                case 7:
                    FillCitiesDGV(cities.GetCities().ToList());
                    break;
                case 8:
                    FillAirportsDGV(airports.GetAirports().ToList());
                    break;
            }
        }

        //функция позволяет выделить строку при клике по ней правой кнопкой мыши
        //а также делает недоступным кнопку "изменение" контекстного меню у "страны"
        private void RightClickSelection(DataGridView dataGridView, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridView == dgvCountries)
                {
                    contextMenu.Items[1].Enabled = false;
                }
                else
                {
                    contextMenu.Items[1].Enabled = true;
                }
                if (dataGridView == dgvTickets)
                {
                    contextMenu.Items[3].Enabled = true;
                }
                else
                {
                    contextMenu.Items[3].Enabled = false;
                }
                    var h = dataGridView.HitTest(e.X, e.Y);
                if (h.Type == DataGridViewHitTestType.Cell)
                {
                    //string LNK_id = dgvPassengers.Rows[h.RowIndex].Cells[0].Value.ToString();
                    dataGridView.Rows[h.RowIndex].Selected = true;
                }
            }
        }

        private void dgvPassengers_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvPassengers, e);
        }

        private void dgvDocuments_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvDocuments, e);
        }

        private void dgvTickets_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvTickets, e);
        }

        private void dgvFlights_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvFlights, e);
        }

        private void dgvAirplanes_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvAirplanes, e); ;
        }

        private void dgvAirlines_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvAirlines, e);
        }

        private void dgvCountries_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvCountries, e);
        }

        private void dgvCities_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvCities, e);
        }

        private void dgvAirports_MouseDown(object sender, MouseEventArgs e)
        {
            RightClickSelection(dgvAirports, e);
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string action = "Add";
                string dataGridView;
                if (contextMenu.SourceControl == dgvPassengers)
                {
                    dataGridView = "Passengers";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Passengers passenger = new Passengers(0, newForm.dtPassengerDateOfBirth.Value, newForm.tbPassengerSurname.Text,
                            newForm.tbPassengerName.Text, newForm.tbPassengerPatronymic.Text);
                        passengers.AddPassenger(passenger);
                        FillPassengersDGV(passengers.GetPassengers().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvDocuments)
                {
                    dataGridView = "Documents";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Documents document = new Documents(newForm.tbDocumentNumber.Text, newForm.tbDocumentType.Text, newForm.cbDocumentCountry.Text,
                            Convert.ToInt32(newForm.cbOwnerId.Text));
                        documents.AddDocument(document);
                        FillDocumentsDGV(documents.GetDocuments().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvTickets)
                {
                    dataGridView = "Tickets";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Tickets ticket = new Tickets(0, newForm.cbTicketDocument.Text, Convert.ToInt32(newForm.cbTicketFlight.Text),
                            newForm.tbTicketSeatNumber.Text, Convert.ToDecimal(newForm.tbTicketCost.Text));
                        tickets.AddTicket(ticket);
                        FillTicketsDGV(tickets.GetTickets().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvFlights)
                {
                    dataGridView = "Flights";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Flights flight = new Flights(0, newForm.cbFlightAirplane.Text, newForm.cbFlightAirportD.Text,
        newForm.cbFlightAirportA.Text, newForm.dtDepartDate.Value, newForm.dtArriveDate.Value);
                        flights.AddFlight(flight);
                        FillFlightsDGV(flights.GetFlights().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirplanes)
                {
                    dataGridView = "Airplanes";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Airplanes airplane = new Airplanes(newForm.tbAirplaneNumber.Text, newForm.tbAirplaneName.Text,
                            newForm.cbAirplaneAirlines.Text, Convert.ToInt32(newForm.tbAirplaneSeats.Text));
                        airplanes.AddAirplane(airplane);
                        FillAirplanesDGV(airplanes.GetAirplanes().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirlines)
                {
                    dataGridView = "Airlines";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Airlines airline = new Airlines(newForm.tbAirlinesName.Text, newForm.cbAirlinesCountry.Text);
                        airlines.AddAirline(airline);
                        FillAirlinesDGV(airlines.GetAirlines().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvCountries)
                {
                    dataGridView = "Countries";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Countries country = new Countries(newForm.tbCountries.Text);
                        countries.AddCountry(country);
                        FillCountriesDGV(countries.GetCountries().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvCities)
                {
                    dataGridView = "Cities";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Cities city = new Cities(0, newForm.tbCityName.Text, newForm.cbCityCountry.Text);
                        cities.AddCity(city);
                        FillCitiesDGV(cities.GetCities().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirports)
                {
                    dataGridView = "Airports";
                    AddForm newForm = new AddForm(dataGridView, action);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Airports airport = new Airports(newForm.tbAirportCode.Text, newForm.tbAirportName.Text,
                            Convert.ToInt32(newForm.cbAirportCity.Text));
                        airports.AddAirport(airport);
                        FillAirportsDGV(airports.GetAirports().ToList());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string action = "Edit";
                string dataGridView;
                if (contextMenu.SourceControl == dgvPassengers)
                {
                    dataGridView = "Passengers";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvPassengers.SelectedCells[0].RowIndex;
                    string id = dgvPassengers.Rows[currentRowIndex].Cells[0].Value.ToString();
                    newForm.tbPassengerSurname.Text = dgvPassengers.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.tbPassengerName.Text = dgvPassengers.Rows[currentRowIndex].Cells[2].Value.ToString();
                    newForm.tbPassengerPatronymic.Text = dgvPassengers.Rows[currentRowIndex].Cells[3].Value.ToString();
                    newForm.dtPassengerDateOfBirth.Value = Convert.ToDateTime(dgvPassengers.Rows[currentRowIndex].Cells[4].Value);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Passengers passenger = new Passengers(Convert.ToInt32(id), newForm.dtPassengerDateOfBirth.Value,
                            newForm.tbPassengerSurname.Text, newForm.tbPassengerName.Text, newForm.tbPassengerPatronymic.Text);
                        passengers.UpdatePassenger(passenger);
                        FillPassengersDGV(passengers.GetPassengers().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvDocuments)
                {
                    dataGridView = "Documents";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvDocuments.SelectedCells[0].RowIndex;
                    newForm.tbDocumentNumber.Enabled = false;
                    newForm.tbDocumentNumber.Text = dgvDocuments.Rows[currentRowIndex].Cells[0].Value.ToString();
                    newForm.tbDocumentType.Text = dgvDocuments.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.cbDocumentCountry.SelectedItem = dgvDocuments.Rows[currentRowIndex].Cells[2].Value.ToString();
                    newForm.cbOwnerId.SelectedItem = dgvDocuments.Rows[currentRowIndex].Cells[3].Value;
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Documents document = new Documents(newForm.tbDocumentNumber.Text, newForm.tbDocumentType.Text, newForm.cbDocumentCountry.Text,
                            Convert.ToInt32(newForm.cbOwnerId.Text));
                        documents.UpdateDocument(document);
                        FillDocumentsDGV(documents.GetDocuments().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvTickets)
                {
                    dataGridView = "Tickets";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvTickets.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvTickets.Rows[currentRowIndex].Cells[0].Value);
                    newForm.cbTicketDocument.SelectedItem = dgvTickets.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.cbTicketFlight.SelectedItem = dgvTickets.Rows[currentRowIndex].Cells[2].Value;
                    newForm.tbTicketSeatNumber.Text = dgvTickets.Rows[currentRowIndex].Cells[3].Value.ToString();
                    newForm.tbTicketCost.Text = dgvTickets.Rows[currentRowIndex].Cells[4].Value.ToString();
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Tickets ticket = new Tickets(id, newForm.cbTicketDocument.Text, Convert.ToInt32(newForm.cbTicketFlight.Text),
                            newForm.tbTicketSeatNumber.Text, Convert.ToDecimal(newForm.tbTicketCost.Text));
                        tickets.UpdateTicket(ticket);
                        FillTicketsDGV(tickets.GetTickets().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvFlights)
                {
                    dataGridView = "Flights";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvFlights.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvFlights.Rows[currentRowIndex].Cells[0].Value);
                    newForm.cbFlightAirplane.SelectedItem = dgvFlights.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.cbFlightAirportD.SelectedItem = dgvFlights.Rows[currentRowIndex].Cells[2].Value.ToString();
                    newForm.cbFlightAirportA.SelectedItem = dgvFlights.Rows[currentRowIndex].Cells[3].Value.ToString();
                    newForm.dtDepartDate.Value = Convert.ToDateTime(dgvFlights.Rows[currentRowIndex].Cells[4].Value.ToString());
                    newForm.dtArriveDate.Value = Convert.ToDateTime(dgvFlights.Rows[currentRowIndex].Cells[5].Value.ToString());
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Flights flight = new Flights(id, newForm.cbFlightAirplane.Text, newForm.cbFlightAirportD.Text,
        newForm.cbFlightAirportA.Text, newForm.dtDepartDate.Value, newForm.dtArriveDate.Value);
                        flights.UpdateFlight(flight);
                        FillFlightsDGV(flights.GetFlights().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirplanes)
                {
                    dataGridView = "Airplanes";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvAirplanes.SelectedCells[0].RowIndex;
                    newForm.tbAirplaneNumber.Enabled = false;
                    newForm.tbAirplaneNumber.Text = dgvAirplanes.Rows[currentRowIndex].Cells[0].Value.ToString();
                    newForm.tbAirplaneName.Text = dgvAirplanes.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.cbAirplaneAirlines.SelectedItem = dgvAirplanes.Rows[currentRowIndex].Cells[2].Value.ToString();
                    newForm.tbAirplaneSeats.Text = dgvAirplanes.Rows[currentRowIndex].Cells[3].Value.ToString();
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Airplanes airplane = new Airplanes(newForm.tbAirplaneNumber.Text, newForm.tbAirplaneName.Text,
                            newForm.cbAirplaneAirlines.Text, Convert.ToInt32(newForm.tbAirplaneSeats.Text));
                        airplanes.UpdateAirplane(airplane);
                        FillAirplanesDGV(airplanes.GetAirplanes().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirlines)
                {
                    dataGridView = "Airlines";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvAirlines.SelectedCells[0].RowIndex;
                    newForm.tbAirlinesName.Enabled = false;
                    newForm.tbAirlinesName.Text = dgvAirlines.Rows[currentRowIndex].Cells[0].Value.ToString();
                    newForm.cbAirlinesCountry.SelectedItem = dgvAirlines.Rows[currentRowIndex].Cells[1].Value.ToString();
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Airlines airline = new Airlines(newForm.tbAirlinesName.Text, newForm.cbAirlinesCountry.Text);
                        airlines.UpdateAirline(airline);
                        FillAirlinesDGV(airlines.GetAirlines().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvCountries)
                {
                    //страны не обновляются
                }
                else if (contextMenu.SourceControl == dgvCities)
                {
                    dataGridView = "Cities";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvCities.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvCities.Rows[currentRowIndex].Cells[0].Value);
                    newForm.tbCityName.Text = dgvCities.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.cbCityCountry.SelectedItem = dgvCities.Rows[currentRowIndex].Cells[2].Value.ToString();
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Cities city = new Cities(id, newForm.tbCityName.Text, newForm.cbCityCountry.Text);
                        cities.UpdateCity(city);
                        FillCitiesDGV(cities.GetCities().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirports)
                {
                    dataGridView = "Airports";
                    AddForm newForm = new AddForm(dataGridView, action);
                    int currentRowIndex = dgvAirports.SelectedCells[0].RowIndex;
                    newForm.tbAirportCode.Enabled = false;
                    newForm.tbAirportCode.Text = dgvAirports.Rows[currentRowIndex].Cells[0].Value.ToString();
                    newForm.tbAirportName.Text = dgvAirports.Rows[currentRowIndex].Cells[1].Value.ToString();
                    newForm.cbAirportCity.SelectedItem = Convert.ToInt32(dgvAirports.Rows[currentRowIndex].Cells[2].Value);
                    if (newForm.ShowDialog(this) == DialogResult.OK)
                    {
                        Airports airport = new Airports(newForm.tbAirportCode.Text, newForm.tbAirportName.Text,
                            Convert.ToInt32(newForm.cbAirportCity.Text));
                        airports.UpdateAirport(airport);
                        FillAirportsDGV(airports.GetAirports().ToList());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (contextMenu.SourceControl == dgvPassengers)
                {
                    int currentRowIndex = dgvPassengers.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvPassengers.Rows[currentRowIndex].Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Passengers passenger = new Passengers(id, Convert.ToDateTime("1999.05.28"), "", "", "");
                        passengers.DeletePassengers(passenger);
                        FillPassengersDGV(passengers.GetPassengers().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvDocuments)
                {
                    int currentRowIndex = dgvDocuments.SelectedCells[0].RowIndex;
                    string id = dgvDocuments.Rows[currentRowIndex].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Documents document = new Documents(id, "", "", 1);
                        documents.DeleteDocument(document);
                        FillDocumentsDGV(documents.GetDocuments().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvTickets)
                {
                    int currentRowIndex = dgvTickets.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvTickets.Rows[currentRowIndex].Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Tickets ticket = new Tickets(id, "", 1, "", 1);
                        tickets.DeleteTicket(ticket);
                        FillTicketsDGV(tickets.GetTickets().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvFlights)
                {
                    int currentRowIndex = dgvFlights.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvFlights.Rows[currentRowIndex].Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Flights flight = new Flights(id, "", "", "", Convert.ToDateTime("1999.05.28"), Convert.ToDateTime("1999.05.28"));
                        flights.DeleteFlight(flight);
                        FillFlightsDGV(flights.GetFlights().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirplanes)
                {
                    int currentRowIndex = dgvAirplanes.SelectedCells[0].RowIndex;
                    string id = dgvAirplanes.Rows[currentRowIndex].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Airplanes airplane = new Airplanes(id, "", "", 1);
                        airplanes.DeleteAirplane(airplane);
                        FillAirplanesDGV(airplanes.GetAirplanes().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirlines)
                {
                    int currentRowIndex = dgvAirlines.SelectedCells[0].RowIndex;
                    string id = dgvAirlines.Rows[currentRowIndex].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Airlines airline = new Airlines(id, "");
                        airlines.DeleteAirline(airline);
                        FillAirlinesDGV(airlines.GetAirlines().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvCountries)
                {
                    int currentRowIndex = dgvCountries.SelectedCells[0].RowIndex;
                    string id = dgvCountries.Rows[currentRowIndex].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Countries country = new Countries(id);
                        countries.DeleteCountry(country);
                        FillCountriesDGV(countries.GetCountries().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvCities)
                {
                    int currentRowIndex = dgvCities.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dgvCities.Rows[currentRowIndex].Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Cities city = new Cities(id, "", "");
                        cities.DeleteCity(city);
                        FillCitiesDGV(cities.GetCities().ToList());
                    }
                }
                else if (contextMenu.SourceControl == dgvAirports)
                {
                    int currentRowIndex = dgvAirports.SelectedCells[0].RowIndex;
                    string id = dgvAirports.Rows[currentRowIndex].Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Удалить", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Airports airport = new Airports(id, "", 1);
                        airports.DeleteAirport(airport);
                        FillAirportsDGV(airports.GetAirports().ToList());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введено неверное значение: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void скидкаНаБилет10ВДеньРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets.DiscountForBirthday();
            tabControl_SelectedIndexChanged(this, new EventArgs());
            MessageBox.Show("Выполнено!", "Скидка 10%", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void отчетToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int currentRowIndex = dgvTickets.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dgvTickets.Rows[currentRowIndex].Cells[0].Value.ToString());
            ReportForm reportForm = new ReportForm(id);
            reportForm.Show();
        }
    }
}