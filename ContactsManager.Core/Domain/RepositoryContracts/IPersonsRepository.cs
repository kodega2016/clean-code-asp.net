using System.Linq.Expressions;
using ContactsManager.Core.Domain.Entities;

namespace ContactsManager.Core.Domain.RepositoryContracts;

///<summary>
///Represents data access logic for managing Person entity
///</summary>
public interface IPersonRepository
{
    ///<summary>
    ///Adds a person object to the data store
    ///</summary>
    ///<param name="person">Person object to add</param>
    ///<returns>Return the person object after adding it into the data store</returns>
    Task<Person> AddPerson(Person person);

    ///<summary>
    ///Returns all the persons in the data store
    ///</summary>
    ///<returns>List of persons object from the data store</returns>
    Task<List<Person>> GetAllPersons();

    ///<summary>
    /// Returns a person object based on the given person id
    ///</summary>
    ///<param name="personId">PersonID to search</param>
    ///<returns>A person object or null</returns>
    Task<Person?> GetPersonByPersonId(Guid personId);

    /// <summary>
    ///  Returns all person objects based on the given expression
    /// </summary>
    /// <param name="predicate">LINQ expression to check</param>
    /// <param name="ordinalIgnoreCase"></param>
    /// <returns>All matching persons with given condition</returns>
    Task<List<Person>> GetFilteredPersons(
        Expression<Func<Person, bool>> predicate,
        StringComparison ordinalIgnoreCase
    );

    ///<summary>
    /// Delete a person object based on the person id
    ///</summary>
    ///<param name="personId">PersonId(guid) to search</param>
    ///<returns>Returns true,if the deletion is success</returns>
    Task<bool> DeletePersonByPersonId(Guid personId);

    ///<summary>
    ///Update a person object(person name and other details) based on the given person id
    ///</summary>
    ///<param name="person">Person object to update</param>
    ///<returns>Returns the updated person object</returns>
    Task<Person> UpdatePerson(Person person);
}
