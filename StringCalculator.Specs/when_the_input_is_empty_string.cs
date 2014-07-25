using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_empty_string : given_a_string_calculator_context
    {
        
        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("");
        };

        It should_return_number_negative_one = () =>
        {
            _result.ShouldEqual(-1);
        };
        static int _result;
    }
}