using ISR.Core.Entities;
using ISR.Core.Enums;
using ISR.Core.Services.Interfaces;

namespace ISR.Core.Services
{
    public class ISRServices : IISRService
    {
        private readonly (double lowerLimit, double supLimit, double cuota, double sobExLI)[] isrRanges = new[]
        {
            (0.01, 7735.00, 0.0, 1.92),
            (7735.01, 65651.07, 148.51, 6.40),
            (65651.08, 115375.90, 3855.14, 10.88),
            (115375.91, 134119.41, 9265.20, 16.00),
            (134119.42, 160577.65, 12264.16, 17.92),
            (160577.66, 323862.00, 17005.47, 21.36),
            (323862.01, 510451.00, 51883.01, 23.52),
            (510451.01, 974535.03, 95768.74, 30.00),
            (974535.04, 1299380.04, 23499.95, 32.00),
            (1299380.05, 3898140.12, 338944.34, 34.00),
            (3898140.13, double.MaxValue, 1222522.76, 35.00)
        };

        public Isr ProcessIsr(user us)
        {
            var isr = new Isr();

            // Imprimir solo la segunda columna
            var isrRange = isrRanges.FirstOrDefault(x => us.salary > x.lowerLimit && us.salary < x.supLimit);
            if (!isrRange.Equals(default))
            {
                isr.isrTotal = (((us.salary - isrRange.lowerLimit) * (isrRange.sobExLI / 100)) + isrRange.cuota);
            }


            return isr;
        }
    }
}
