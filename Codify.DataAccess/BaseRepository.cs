using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codify.DataAccess
{
    public abstract class BaseRepository
    {
        private readonly DbContext _dataContext;

        protected BaseRepository(DbContext dataContext)
        {
            _dataContext = dataContext;

        }

        public string SaveChanges()
        {
            var errMsg = string.Empty;
            try
            {
                var result = _dataContext.SaveChanges();

                if (result > 0)
                {
                    return "Success";
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                errMsg = dbEx.EntityValidationErrors.Aggregate(errMsg,
                    (current1, validationErrors) =>
                        validationErrors.ValidationErrors.Aggregate(current1,
                            (current, validationError) =>
                                current +
                                string.Format("Field: {0},  Error: {1}", validationError.PropertyName,
                                    validationError.ErrorMessage)));
            }
            catch (DbUpdateException dbUpdateExceptionEx)
            {
                var err = dbUpdateExceptionEx.InnerException.InnerException.Message;
                errMsg = err.Replace("\r\n", "").Replace("The statement has been terminated.", "");
            }

            return errMsg;
        }

    }
}
