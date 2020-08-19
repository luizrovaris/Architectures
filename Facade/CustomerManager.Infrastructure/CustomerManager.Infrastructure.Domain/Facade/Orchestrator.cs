using CustomerManager.Infrastructure.Domain.Domain;
using CustomerManager.Infrastructure.Model.Exchange;
using FluentValidation;
using FluentValidation.Results;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Infrastructure.Domain.Facade
{
    public class Orchestrator
    {
        public static async Task<T2> Execute<T, T1, T2, TValid>(IDomainBase domain, T1 request)
            where T : FacadeOrchestration<T1, T2>, new()
            where T1 : FacadeRequestBase
            where T2 : FacadeResponseBase, new()
            where TValid : AbstractValidator<T1>, new()
        {
            FacadeOrchestration<T1, T2> orchestrationModel = new T();
            T2 response = new T2();

            try
            {
                response.RequestKey = request.RequestKey;

                ValidationResult validator = new TValid().Validate(request);

                if (!validator.IsValid)
                {
                    response.AddError(validator);
                }

                if (response.Success)
                {
                    domain.BaseError.ClearErrors();

                    response = await orchestrationModel.Execute(domain, request, response);

                    if (domain.BaseError != null && domain.BaseError.Errors.Any())
                    {
                        response.AddError(domain.BaseError.Errors);
                    }
                }
            }
            catch (System.Exception ex)
            {
                response.AddError(ex);
            }

            return response;
        }
    }
}