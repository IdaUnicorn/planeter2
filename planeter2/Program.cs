using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace planeter2
{
    class Program
    {
        static void Main(string[] args)
        //Design og opret din ”Planet” klasse med de tilhørende properties.

        {
            Planeter Merkur = new Planeter("Merkur");
            Merkur.Mass_kg = 0.330f;
            Merkur.Diameter_km = 4879f;
            Merkur.Density_kgprm3 = 5427f;
            Merkur.Gravity_mprs2 = 3.7f;
            Merkur.Rotation_period_hours = 1407.6f;
            Merkur.Lenght_of_day_hours = 4222.6f;
            Merkur.Distance_from_sun_106km = 57.9f;
            Merkur.Orbital_period_days = 88.0f;
            Merkur.Orbital_velocity_kmprs = 47.4f;
            Merkur.Mean_temperature_C = 167f;
            Merkur.Number_of_moons = 0f;
            Merkur.Ring_system_y_n = false;


            Planeter Jorden = new Planeter("Jorden");
            Jorden.Mass_kg = 5.97f;
            Jorden.Diameter_km = 12756f;
            Jorden.Density_kgprm3 = 5514f;
            Jorden.Gravity_mprs2 = 9.8f;
            Jorden.Rotation_period_hours = 23.9f;
            Jorden.Lenght_of_day_hours = 24.0f;
            Jorden.Distance_from_sun_106km = 149.6f;
            Jorden.Orbital_period_days = 365.2f;
            Jorden.Orbital_velocity_kmprs = 29.8f;
            Jorden.Mean_temperature_C = 15f;
            Jorden.Number_of_moons = 1f;
            Jorden.Ring_system_y_n = false;

            Planeter Mars = new Planeter("Mars");
            Mars.Mass_kg = 0.642f;
            Mars.Diameter_km = 6792f;
            Mars.Density_kgprm3 = 3933f;
            Mars.Gravity_mprs2 = 3.7f;
            Mars.Rotation_period_hours = 24.6f;
            Mars.Lenght_of_day_hours = 24.7f;
            Mars.Distance_from_sun_106km = 227.9f;
            Mars.Orbital_period_days = 687.0f;
            Mars.Orbital_velocity_kmprs = 24.1f;
            Mars.Mean_temperature_C = -65f;
            Mars.Number_of_moons = 2f;
            Mars.Ring_system_y_n = false;

            Planeter Jupiter = new Planeter("Jupiter");
            Jupiter.Mass_kg = 1898f;
            Jupiter.Diameter_km = 142984f;
            Jupiter.Density_kgprm3 = 1326f;
            Jupiter.Gravity_mprs2 = 23.1f;
            Jupiter.Rotation_period_hours = 9.9f;
            Jupiter.Lenght_of_day_hours = 9.9f;
            Jupiter.Distance_from_sun_106km = 778.6f;
            Jupiter.Orbital_period_days = 4331f;
            Jupiter.Orbital_velocity_kmprs = 13.1f;
            Jupiter.Mean_temperature_C = -110f;
            Jupiter.Number_of_moons = 67f;
            Jupiter.Ring_system_y_n = true;

            Planeter Saturn = new Planeter("Saturn");
            Saturn.Mass_kg = 568f;
            Saturn.Diameter_km = 120536f;
            Saturn.Density_kgprm3 = 687f;
            Saturn.Gravity_mprs2 = 9.0f;
            Saturn.Rotation_period_hours = 10.7f;
            Saturn.Lenght_of_day_hours = 10.7f;
            Saturn.Distance_from_sun_106km = 1433.5f;
            Saturn.Orbital_period_days = 10747f;
            Saturn.Orbital_velocity_kmprs = 9.7f;
            Saturn.Mean_temperature_C = -140f;
            Saturn.Number_of_moons = 62f;
            Saturn.Ring_system_y_n = true;

            Planeter Uranus = new Planeter("Uranus");
            Uranus.Mass_kg = 86.8f;
            Uranus.Diameter_km = 51118f;
            Uranus.Density_kgprm3 = 1271f;
            Uranus.Gravity_mprs2 = 8.7f;
            Uranus.Rotation_period_hours = -17.2f;
            Uranus.Lenght_of_day_hours = 17.2f;
            Uranus.Distance_from_sun_106km = 2872.5f;
            Uranus.Orbital_period_days = 30589f;
            Uranus.Orbital_velocity_kmprs = 6.8f;
            Uranus.Mean_temperature_C = -195f;
            Uranus.Number_of_moons = 27f;
            Uranus.Ring_system_y_n = true;

            Planeter Neptun = new Planeter("Neptun");
            Neptun.Mass_kg = 102f;
            Neptun.Diameter_km = 49528f;
            Neptun.Density_kgprm3 = 1638f;
            Neptun.Gravity_mprs2 = 11.0f;
            Neptun.Rotation_period_hours = 16.1f;
            Neptun.Lenght_of_day_hours = 16.1f;
            Neptun.Distance_from_sun_106km = 4495.1f;
            Neptun.Orbital_period_days = 598f;
            Neptun.Orbital_velocity_kmprs = 5.4f;
            Neptun.Mean_temperature_C = -200f;
            Neptun.Number_of_moons = 14f;
            Neptun.Ring_system_y_n = true;

            Planeter Pluto = new Planeter("Pluto");
            Pluto.Mass_kg = 0.0146f;
            Pluto.Diameter_km = 2370f;
            Pluto.Density_kgprm3 = 2095f;
            Pluto.Gravity_mprs2 = 0.7f;
            Pluto.Rotation_period_hours = -153.3f;
            Pluto.Lenght_of_day_hours = 153.3f;
            Pluto.Distance_from_sun_106km = 5906.4f;
            Pluto.Orbital_period_days = 9056f;
            Pluto.Orbital_velocity_kmprs = 4.7f;
            Pluto.Mean_temperature_C = -225f;
            Pluto.Number_of_moons = 5f;
            Pluto.Ring_system_y_n = false;

            Planeter Venus = new Planeter("Venus");
            Venus.Mass_kg = 4.87f;
            Venus.Diameter_km = 12104f;
            Venus.Density_kgprm3 = 5243f;
            Venus.Gravity_mprs2 = 8.9f;
            Venus.Rotation_period_hours = -5832.5f;
            Venus.Lenght_of_day_hours = 2802.0f;
            Venus.Distance_from_sun_106km = 108.2f;
            Venus.Orbital_period_days = 224.7f;
            Venus.Orbital_velocity_kmprs = 35.0f;
            Venus.Mean_temperature_C = 464f;
            Venus.Number_of_moons = 0f;
            Venus.Ring_system_y_n = false;


            //Opret en liste som du kan kalde planets og tilføj følgende planeter Merkur, Jorden, Mars, Jupiter, Saturn, Uranus, Neptun, 
            //Pluto ved at bruge Add metoden. Husk at du først skal instantiere objekterne.

            List<Planeter> planets = new List<Planeter> { Merkur, Jorden, Mars, Jupiter, Saturn, Uranus, Neptun, Pluto };

            //Udskriv nu din liste, ved at bruge foreach løkken.


            foreach (Planeter item in planets)
            {
                Console.WriteLine(item.Name);
                Console.Read();
            }

            //I listen over planeter, mangler der Venus. Så Venus skal indsættes i listen. Da planeter er sorteret 
            //i rækkefølge fra Solen, skal Venus indsættes lige efter Merkur og lige før Jorden.
            planets.Insert(1, Venus);

            foreach (Planeter item in planets)
            {
                Console.WriteLine(item.Name);
                Console.Read();
            }

            //Fjers Pluto fra listen.
            planets.Remove(Pluto);
            foreach (Planeter item in planets)
            {
                Console.WriteLine(item.Name);
                Console.Read();
            }
            //indsæt Pluto igen. 
            planets.Insert(7, Pluto);

            foreach (Planeter item in planets)
            {
                Console.WriteLine(item.Name);
                Console.Read();
            }
            //udskriv antallet af planeter i konsollen.
            Console.WriteLine(planets.Count);
            Console.Read();

            //Opret en ny liste og indsæt alle de elementer i listen, som har en ”mean temperature” 
            //under 0, udskriv din nye liste – i denne bør der ligge Mars, Jupiter, Saturn, Uranus, Neptun og Pluto.

            List<Planeter> Temp = new List<Planeter> { Mars, Jupiter, Saturn, Uranus, Neptun, Pluto };

            foreach (Planeter item in Temp)
            {
                Console.WriteLine(item.Name);
                Console.Read();
            }
            //Opret en ny liste og tilføj alle de planeter som har en diameter på over 10000 km – men under 50000 km.
            foreach (Planeter item in planets)
            {
                Console.WriteLine(item.Name);
                Console.Read();

                if (item.Diameter_km > 10000 && item.Diameter_km < 50000) //går igennem listen 
                    Console.WriteLine(planets);
            }
            //Prøv som det sidste at fjerne alle planeter fra listen.
            planets.Clear();

            foreach (Planeter item in planets)
            {
                Console.WriteLine(item.Name);
                Console.Read();


            }



        }
    }
}




    
