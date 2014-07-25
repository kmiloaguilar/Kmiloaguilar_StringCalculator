using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_1 : given_a_string_calculator_context
    {

        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("1");
        };

        It should_return_the_number_1 = () =>
        {
            _result.ShouldEqual(1);
        };

        static int _result;
    }
}