using System;

namespace ExampleProject
{
    public class UserService
    {
        // todo: Добавить валидацию email | priority: high | category: feature
        public void RegisterUser(string email, string password)
        {
            /* todo: Реализовать хеширование пароля | priority: high | category: security | assignee: @security-team */
            throw new NotImplementedException();
        }

        /*
         * todo: Добавить интеграцию с внешним API | priority: medium | category: feature | tags: api,integration
         */
        public async Task<bool> ValidateUserCredentials(string email, string password)
        {
            // todo: Добавить логирование | priority: low
            return false;
        }

        /* todo: Реализовать восстановление пароля | priority: medium | category: feature | assignee: @john */
        private void SendPasswordResetEmail()
        {
            // Здесь будет код отправки email
        }
    }
}