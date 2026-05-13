using System;
using ClinicaAPI.Models;
using Xunit;

namespace ClinicaAPI.Tests
{
    public class PacienteTests
    {
        [Fact]
        public void Paciente_AsignarPropiedades_ValoresCorrectos()
        {
            // Arrange
            var paciente = new Paciente
            {
                Id = 2,
                Nombre = "Ana Martínez",
                Edad = 28,
                Diagnostico = "Consulta general",
                Telefono = "987654321",
                Direccion = "Av. Los Incas 123",
                CorreoElectronico = "ana@example.com",
                FechaRegistro = DateTime.Now
            };

            // Act & Assert
            Assert.Equal(2, paciente.Id);
            Assert.Equal("Ana Martínez", paciente.Nombre);
            Assert.Equal(28, paciente.Edad);
            Assert.Equal("Consulta general", paciente.Diagnostico);
            Assert.Equal("987654321", paciente.Telefono);
            Assert.Equal("Av. Los Incas 123", paciente.Direccion);
            Assert.Equal("ana@example.com", paciente.CorreoElectronico);
            Assert.NotNull(paciente.FechaRegistro);
        }

        [Fact]
        public void Paciente_CorreoElectronico_FormatoValido()
        {
            // Arrange
            var paciente = new Paciente
            {
                CorreoElectronico = "test@domain.com"
            };

            // Act
            var esValido = paciente.CorreoElectronico.Contains("@") &&
                           paciente.CorreoElectronico.Contains(".");

            // Assert
            Assert.True(esValido);
        }
    }
}