using WordProcessorProject;

namespace WordProcessorProjectTests
{
    [TestFixture(typeof(Word365Document))]
    public class WordProcessorTests<T> where T : class, new()
    {

        private T wordDocument;

        [SetUp]
        public void Setup()
        {
            wordDocument = new T();
        }

        [Test]
        public void Print_When_Implemented_Then_DoNotThrowException()
        {

            var wp = new WordProcessor();

            //Assert.NotNull(wordDocument, "Word document is Null. Test cannot continue.");
            Assert.NotNull(wordDocument);
            Assert.That(wordDocument, Is.Not.Null);

            Assert.IsInstanceOf<IDocument>(wordDocument);
            Assert.That(wordDocument, Is.InstanceOf<IDocument>());

            //Assert.IsInstanceOf(typeof(WordDocument), wordDocument);


            Assert.IsAssignableFrom<Word365Document>(wordDocument);
            Assert.That(wordDocument, Is.AssignableFrom<Word365Document>());


            Assert.IsNotAssignableFrom<PdfDocument>(wordDocument);
            Assert.That(wordDocument, Is.Not.AssignableFrom<PdfDocument>());

            Assert.DoesNotThrow(() => { wp.Print(wordDocument as WordDocument); });
            Assert.That(() => { wp.Print(wordDocument as WordDocument); }, Throws.Nothing);

        }

        [Test]
        public void Print_When_NotImplemented_Then_ThrowException()
        {
            var document = new PdfDocument();
            var wp = new WordProcessor();
            Assert.Throws<NotImplementedException>(() => { wp.Print(document); });

            Assert.That(() => { wp.Print(document); }, Throws.Exception.InstanceOf<NotImplementedException>());
        }
    }
    
}