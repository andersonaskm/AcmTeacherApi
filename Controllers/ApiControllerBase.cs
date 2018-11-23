using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Threading.Tasks;

namespace AcmTeacherApi.Controllers
{
    public class ApiControllerBase: ControllerBase
    {
        #region [Properties]

        

        #endregion

        #region [Ctor]

        

        #endregion

        #region [Methods]

        protected async Task<IActionResult> AsyncHandler<TParam>(Func<TParam, Task<IActionResult>> requestHandler, TParam param)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Log.Debug("Iniciando a execução");                    
                    var ret = await requestHandler(param);
                    Log.Debug("Finalizando a execução");

                    return ret;
                }

                else
                {
                    var responseError = HandleInvalidModelState();
                    return BadRequest(responseError);
                }
            }



            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);

                var errorResponse = "Erro ao processar a sua requisição.";
                return StatusCode(500, errorResponse);
            }
        }

        protected async Task<IActionResult> AsyncHandler(Func<Task<IActionResult>> requestHandler)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Log.Debug("Iniciando a execução");
                    var ret = await requestHandler();
                    Log.Debug("Finalizando a execução");

                    return ret;
                }

                else
                {
                    var responseError = HandleInvalidModelState();
                    return BadRequest(responseError);
                }
            }



            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);

                var errorResponse = "Erro ao processar a sua requisição.";
                return StatusCode(500, errorResponse);
            }
        }

      

        private string HandleInvalidModelState()
        {
            return String.Empty;
        }

        #endregion

    }
}
