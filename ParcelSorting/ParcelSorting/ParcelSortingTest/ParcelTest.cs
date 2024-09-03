using Microsoft.VisualStudio.TestPlatform.TestHost;
using ParcelSorting;

namespace ParcelSortingTest
{
    public class ParcelTest
    {
        [Fact]
        public void When_ParceAndSortingLineHasNewDimensions_Then_ParcelCanNotFitSortingLine()
        {
            var boxSixes = new List<BoxSize>()
            {
                new BoxSize
                {
                    Length = 70,
                    Width = 50,
                    SortingLineParam = new List<SortingLineParam>()
                    {
                        new SortingLineParam
                        {
                            LineWidth = 50,
                        },
                        new SortingLineParam
                        {
                            LineWidth = 50,
                        },
                        new SortingLineParam
                        {
                            LineWidth = 100,
                        },
                        new SortingLineParam
                        {
                            LineWidth = 100,
                        },
                    }
                }
            };

            bool result = Program.ParcelLineFitController(BoxSize);

            Assert.False(result);
        }
    }
}