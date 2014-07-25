using Machine.Specifications;

namespace StringCalculator.Specs
{
    public class when_the_input_is_2_plus_1 : given_a_string_calculator_context
    {
        

        Because of = () =>
        {
            _result = StringCalcutorObject.Calculate("2+1");
        };

        It should_return_the_number_3 = () =>
        {
            _result.ShouldEqual(3);
        };
        static int _result;
    }
}