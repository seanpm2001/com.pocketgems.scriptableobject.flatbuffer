using System.Collections.Generic;
using PocketGems.Parameters.Common.Models.Editor;
using PocketGems.Parameters.DataGeneration.LocalCSV.Rows.Editor;
using PocketGems.Parameters.Interface;

namespace PocketGems.Parameters.DataGeneration.LocalCSV.Editor
{
    public interface IStructCSVFileCache : ICSVFileCache<IBaseStruct, IParameterStruct>
    {
        /// <summary>
        ///  Loads a particular CSV Row by T and guid
        /// </summary>
        /// <param name="guid">guid in the CSVFile to return</param>
        /// <typeparam name="T">IParameterStruct of type T</typeparam>
        /// <returns>CSVRow</returns>
        CSVRow LoadRow<T>(string guid) where T : IBaseStruct;

        /// <summary>
        /// Returns this history of all calls to LoadRow<T>
        ///
        /// Key: baseName of interface T
        /// Values: HashSet of guids
        /// </summary>
        IReadOnlyDictionary<string, HashSet<string>> LoadRowHistory { get; }

        /// <summary>
        /// Clears all history of calls to LoadRow<T>
        /// </summary>
        void ClearLoadRowHistory();
    }
}
