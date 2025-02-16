﻿using dqt.datalayer.Model;
using dqt.datalayer.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dqt.domain.QTS
{
    public class QualifiedTeachersService : IQualifiedTeachersService
    {
        private readonly IRepository<QualifiedTeacher> _qualifiedTeachersRepository;

        public QualifiedTeachersService(IRepository<QualifiedTeacher> repo)
        {
            _qualifiedTeachersRepository = repo;
        }

        public async Task<IEnumerable<QualifiedTeacher>> GetQualifiedTeacherRecords(string teacherReferenceNumber, string nationalInsuranceNumber)
        {
            var qts = await _qualifiedTeachersRepository.FindAsync(x => x.Trn == teacherReferenceNumber);
            
            if (!qts.Any())
            {
                if (!string.IsNullOrWhiteSpace(nationalInsuranceNumber))
                {
                    qts = await _qualifiedTeachersRepository.FindAsync(x => x.NINumber == nationalInsuranceNumber);
                }
            }

            return qts;
        }
    }
}
