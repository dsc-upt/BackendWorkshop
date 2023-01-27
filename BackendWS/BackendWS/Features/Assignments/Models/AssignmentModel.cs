using BackendWS.Base.Models;

namespace BackendWS.Features.Assignments.Models;

public class AssignmentModel : Model
{
    public string Subject { get; set; }
    
    public string Description { get; set; }
    
    public DateTime Deadline { get; set; }
}