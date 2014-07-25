using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_2 : given_a_string_calculator_context
    {

        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("2");
        };

        It should_return_number_2 = () =>
        {

            _result.ShouldEqual(2);
        };
        
        static int _result;
    }
}