using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class RulesManager : IRulesService
    {
        private readonly IRulesDal _rulesDal;

        public RulesManager(IRulesDal rulesDal)
        {
            _rulesDal = rulesDal;
        }
        public async Task<Rules> GetRulesWithIdAsync(int id)
        {
            return await _rulesDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Rules>> GetAllRulesAsync()
        {
            return await _rulesDal.GetAllAsync();
        }

        public Task<bool> AddRulesAsync(Rules rules)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRulesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRulesAsync(Rules rules)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Rules>> GetAllRulesAsync(string languageCode)
        {
            return await _rulesDal.GetRulesAsync(languageCode);

        }
        public async Task<bool> RulesAnyAsync(Expression<Func<Rules, bool>> expression)
        {
            return await _rulesDal.CheckRules(expression);
        }
    }
}
