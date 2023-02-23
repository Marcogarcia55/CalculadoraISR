    using ISR.Core.Entities;

    namespace ISR.Core.Services.Interfaces;

    public interface IISRService
    {
        Isr ProcessIsr(user person);
        
    }