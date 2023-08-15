using FastEndpoints;

namespace Traveler.Minimal.Api.Features.Journal.Create
{
    public class JournalCreateEndpoint : Endpoint<JournalCreateRequest, JournalCreateResponse>
    {
        public override void Configure()
        {
            Post("/api/jounral/create");
            AllowAnonymous();
        }

        public override async Task HandleAsync(JournalCreateRequest req, CancellationToken ct)
        {
            await SendAsync(new()
            {

            });
        }
    }
}
