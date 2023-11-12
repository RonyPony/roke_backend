﻿using Microsoft.AspNetCore.Mvc;
using Roke.Core.Model;
using RokeBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokeBackend.core.Contracts
{
    public interface IFormRepository
    {

        public Task<Form> CreateForm(Form data);

        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>


       // public IEnumerable<brigade> getAllBrigades();
        public Task<Form> getFormByIdAsync(Guid id);
       // public Task<brigade> GetBrigadeById(Guid id);
        
        //public Task<Form> asignBrigades(brigadeAssigne data);
        //public Task<brigadeAssigne> asignBrigadesByTemplate(brigadeAssigne data);


        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<Form> UpdateForm(Form data);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> RemoveForm(Guid id);
    
    }
}
