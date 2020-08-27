using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planeter2
{
    class Planeter
    {
        /// class variables
        private string name;
        private float mass_kg;
        private float diameter_km;
        private float density_kgprm3;
        private float gravity_mprs2;
        private float rotation_period_hours;
        private float lenght_of_day_hours;
        private float distance_from_sun_106km;
        private float orbital_period_days;
        private float orbital_velocity_kmprs;
        private float mean_temperature_C;
        private float number_of_moons;
        private bool ring_system_y_n;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public float Mass_kg
        {
            get { return this.mass_kg; }
            set { this.mass_kg = value; }
        }
        public float Diameter_km
        {
            get { return this.diameter_km; }
            set { this.diameter_km = value; }
        }
        public float Density_kgprm3
        {
            get { return this.density_kgprm3; }
            set { this.density_kgprm3 = value; }
        }
        public float Gravity_mprs2
        {
            get { return this.gravity_mprs2; }
            set { this.gravity_mprs2 = value; }
        }
        public float Rotation_period_hours
{
            get { return this.rotation_period_hours; }
            set { this.rotation_period_hours = value; }
        }
        public float Lenght_of_day_hours
        {
            get { return this.lenght_of_day_hours; }
            set { this.lenght_of_day_hours = value; }
        }
        public float Distance_from_sun_106km
        {
            get { return this.distance_from_sun_106km; }
            set { this.distance_from_sun_106km = value; }
        }
        public float Orbital_period_days
        {
            get { return this.orbital_period_days; }
            set { this.orbital_period_days = value; }
        }
        public float Orbital_velocity_kmprs
        {
            get { return this.orbital_velocity_kmprs; }
            set { this.orbital_velocity_kmprs = value; }
        }
        public float Mean_temperature_C
        {
            get { return this.mean_temperature_C; }
            set { this.mean_temperature_C = value; }
        }
        public float Number_of_moons
        {
            get { return this.number_of_moons; }
            set { this.number_of_moons = value; }
        }
        public bool Ring_system_y_n
        {
            get { return this.ring_system_y_n; }
            set { this.ring_system_y_n = value; }
        }



        public Planeter(string Name)
        {
            name = Name;



        }
        

    }
}
