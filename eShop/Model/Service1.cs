namespace eShop.Model
{
    public class Service1
    {
        public void Calculate(int number)
        {
            try
            {
                var a = 5 / number;

            }
            catch (Exception e)
            {
                throw new Exception("خطای محاسباتی", e);
            }

        }
    }
}
