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
            Assert.That(wordDocument, Is.Not.Null);
            Assert.That(wordDocument, Is.InstanceOf<WordProcessor>());
            Assert.That(wordDocument, Is.InstanceOf<IDocument>());
            Assert.That(wordDocument, Is.AssignableFrom<Word365Document>());
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