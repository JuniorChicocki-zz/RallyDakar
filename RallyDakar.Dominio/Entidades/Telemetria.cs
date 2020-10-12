using System;

namespace RallyDakar.Dominio.Entidades
{
    public class Telemetria
    {
        public int Id { get; set; }
        public int TemporadaId { get; set; }
        public int PilotoId { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal PercentualCombustivel { get; set; }
        public decimal Velicidade { get; set; }
        public decimal Rpm { get; set; }
        public int TemperatudaMotor { get; set; }
        public int TemperaturaExterna { get; set; }
        public Decimal AltidudeNivelMar { get; set; }
        public bool PedalAcelerador { get; set; }
        public bool PedalFreio { get; set; }
    }
}
