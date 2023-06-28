using WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddUser(AppUser appUser)
        {
            _context.AppUsers.Add(appUser);
            _context.SaveChanges();
        }

        public void UpdateUser(AppUser appUser)
        {
            _context.AppUsers.Update(appUser);
            _context.SaveChanges();
        }

        public void DeleteUser(string id)
        {
            var e = _context.AppUsers.FirstOrDefault(t => t.AppUserId == id);
            _context.AppUsers.Remove(e);
            _context.SaveChanges();
        }

        public AppUser GetUserSingleRecord(string id)
        {
            return _context.AppUsers.FirstOrDefault(t => t.AppUserId == id);
        }

        public List<AppUser> GetUserInfo()
        {
            return _context.AppUsers.ToList();
        }

        public void AddProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }

        public void DeleteProject(string projectId)
        {
            var project = _context.Projects.FirstOrDefault(p => p.ProjectId == projectId);
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public Project GetProjectSingleRecord(string projectId)
        {
            return _context.Projects.FirstOrDefault(p => p.ProjectId == projectId);
        }

        public List<Project> GetProjectInfo()
        {
            return _context.Projects.ToList();
        }

        public void AddEntity(Entity entity)
        {
            _context.Entities.Add(entity);
            _context.SaveChanges();
        }

        public void UpdateEntity(Entity entity)
        {
            _context.Entities.Update(entity);
            _context.SaveChanges();
        }

        public void DeleteEntity(string entityId)
        {
            var entity = _context.Entities.FirstOrDefault(e => e.EntityId == entityId);
            _context.Entities.Remove(entity);
            _context.SaveChanges();
        }

        public Entity GetEntitySingleRecord(string entityId)
        {
            return _context.Entities.FirstOrDefault(e => e.EntityId == entityId);
        }

        public List<Entity> GetEntityInfo()
        {
            return _context.Entities.ToList();
        }
    }
}