using GraphAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphAPI.Queries
{
    public class SerieQuery
    {
        // Método para obtener una serie por su ID
        public Serie GetSerieById(int serieId)
        {
            // Simulación de una base de datos o repositorio de series
            var series = GetSeriesFromDatabase(); // Implementa este método para obtener las series desde una base de datos o donde las almacenes

            // Buscar la serie por su ID
            var serie = series.FirstOrDefault(s => s.Id == serieId);

            return serie;
        }

        // Método para obtener todas las series (simulado)
        public List<Serie> GetSeries()
        {
            // Simulación de una base de datos o repositorio de series
            return GetSeriesFromDatabase(); // Implementa este método para obtener las series desde una base de datos o donde las almacenes
        }

        // Método para simular obtener las series desde una base de datos
        private List<Serie> GetSeriesFromDatabase()
        {
            // Crear una lista de series ficticia (simulación)
            return new List<Serie>
            {
                new Serie
                {
                    Id = 1,
                    Name = "One Piece",
                    ReleaseDate = DateTime.UtcNow.AddDays(-10),
                    Platforms = new List<Platform>
                    {
                        new Platform
                        {
                            Name="Crunchyroll",
                            Followers=1000
                        },
                        new Platform
                        {
                            Name="Netflix",
                            Followers=2000
                        }
                    }
                },
                new Serie
                {
                    Id = 2,
                    Name = "Attack on Titan",
                    ReleaseDate = DateTime.UtcNow.AddDays(-20),
                    Platforms = new List<Platform>
                    {
                        new Platform
                        {
                            Name="Funimation",
                            Followers=1500
                        },
                        new Platform
                        {
                            Name="Hulu",
                            Followers=1800
                        }
                    }
                }
            };
        }
    }
}
