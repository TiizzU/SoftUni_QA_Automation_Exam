namespace FirstTaskIntegrationTests
{
    using FirstTaskIntegrationTests.Models;
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    class DeleteTest : BaseTest
    {
        [Test]
        public async Task DeleteBook()
        {
            //Arrange
            Guid id = userId;

            string bookId = "9de699a7-4924-448c-910c-97bd27f6525b";

            //Act
            var response = await Client.DeleteAsync($"api/authors/{id.ToString()}/books", bookId);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();

            var actualBook = Book.FromJson(responseContent);
            
            //Assert
            actualBook.Title.Should().Be(expectedBook.Title);
            actualBook.Description.Should().Be(expectedBook.Description);


        }

        [Test]
        public async Task PostBook_WithInValidData_ShouldReturnServerError()
        {
            //Arrange
            Guid id = userId;

            var expectedBook = new Book
            {
                Title = "",
                Description = "Mishka"
            };
            var jsonbook = expectedBook.ToJson();
            StringContent requestContent = new StringContent(jsonbook);

            //Act
            var response = await Client.PostAsync($"api/authors/{id.ToString()}/books", requestContent);
            //response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();

            //var actualBook = Book.FromJson(responseContent);

            //Assert
            //actualBook.Title.Should().Be(expectedBook.Title);
            //actualBook.Description.Should().Be(expectedBook.Description);
            response.StatusCode.Should().Be(500);

        }

    }
}
