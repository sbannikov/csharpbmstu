namespace Bmstu.IU6.Teaching.Storage
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class DB : DbContext
    {
        /// <summary>
        /// ���� ������ Entity Framework Code First
        /// </summary>
        public DB() : base("DB")
        {
            // https://stackoverflow.com/questions/30084916/no-connection-string-named-could-be-found-in-the-application-config-file
        }

        /// <summary>
        /// �������������� ���������� ��������
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DB, Migrations.Configuration>());
        }

        /// <summary>
        /// �����������
        /// </summary>
        public virtual DbSet<Ability> Abilities { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        public virtual DbSet<Character> Characters { get; set; }

        /// <summary>
        /// ������ ���� ��� ���� �������
        /// </summary>
        public virtual DbSet<CodeRow>  CodeRows{ get; set; }

        /// <summary>
        /// ��1 ������� � 1 
        /// </summary>
        public virtual DbSet<Exercise1> Exercise1 { get; set; }

        /// <summary>
        /// ��2 ������� � 1 
        /// </summary>
        public virtual DbSet<Exercise21> Exercise21 { get; set; }

        /// <summary>
        /// ��������� ����
        /// </summary>
        public virtual DbSet<Role> Roles { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public virtual DbSet<Student> Students { get; set; }

        /// <summary>
        /// �������� ������ ����������
        /// </summary>
        public virtual DbSet<Principle> Principles { get; set; }

        #region "������-������"

        /// <summary>
        /// ������ ������� ����� ���� ������������� ����������
        /// </summary>
        /// <param name="Number">����� ����������</param>
        /// <returns></returns>
        public List<int> Rows(int Number)
        {
            return CodeRows.Where(a=>a.Number==Number).Select(a => a.Row).OrderBy(a => a).Distinct().ToList();
        }

        #endregion
    }
}