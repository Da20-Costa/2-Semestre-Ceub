﻿using Microsoft.AspNetCore.Mvc;

namespace WebApiExercicioLogica.Controllers
{
    public class VolumePrismaTrianguloController : Controller
    {
        [HttpGet("VolumePrismaTriangulo")]
        public string VolumePrismaTriangulo(double baseTrianguloUsuario, double alturaTrianguloUsuario, double alturaPrismaUsuario)
        {
            double baseTriangulo, alturaTriangulo, alturaPrisma, volumePrismaTriangulo;
            baseTriangulo = baseTrianguloUsuario;
            alturaTriangulo = alturaTrianguloUsuario;
            alturaPrisma = alturaPrismaUsuario;

            volumePrismaTriangulo = ((baseTriangulo * alturaTriangulo) / 2) * alturaPrisma;

            return $"O volume do prisma triangular é: {volumePrismaTriangulo}";
        }
    }
}
