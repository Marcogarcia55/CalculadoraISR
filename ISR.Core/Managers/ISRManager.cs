using ISR.Core.Managers.Interfaces;
using ISR.Core.Entities;
using ISR.Core.Services.Interfaces;


namespace ISR.Core.Managers;

public class ISRManager: IiSRManager
{
    private readonly IISRService _service;

    public ISRManager(IISRService service){
        _service = service;
    }

    public Isr GetISR(user user){
        return _service.ProcessIsr(user);
    }


}

