using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Raven.Client.Documents.Indexes;
using Sample.Models;

namespace Sample.Indexes
{
    public class Talks_SpeakerStats : AbstractIndexCreationTask<Talk, SpeakerTalkStats>
    {
        public Talks_SpeakerStats()
        {
            Map = talks =>
                from talk in talks
                select new
                {
                    Id = talk.Speaker,
                    SpeakerName = LoadDocument<Speaker>(talk.Speaker).Name,
                    Count = 1
                };
        }
    }   
}
