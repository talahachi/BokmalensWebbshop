using Microsoft.EntityFrameworkCore.Migrations;

namespace BokmalensWebbshop.Migrations
{
    public partial class addBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "Price" },
                values: new object[] { 3, "Winston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not tolerate dissent - even in the mind. For those with original thoughts they invented Room 101. . .", null, 32.95m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBookOfTheWeek", "Price", "Title" },
                values: new object[,]
                {
                    { 6, "Margaret Atwood", 1, "The Republic of Gilead offers Offred only one function: to breed. If she deviates, she will, like dissenters, be hanged at the wall or sent out to die slowly of radiation sickness. But even a repressive state cannot obliterate desire - neither Offred's nor that of the two men on which her future hangs. Brilliantly conceived and executed, this powerful evocation of twenty-first century America gives full rein to Margaret Atwood's devastating irony, wit and astute perception.", null, "Handmaids tale.jpg", true, true, 33.95m, "The Handmaid’s Tale" },
                    { 7, "Victor Hugo", 3, "Victor Hugo's tale of injustice, heroism and love follows the fortunes of Jean Valjean, an escaped convict determined to put his criminal past behind him. But his attempts to become a respected member of the community are constantly put under threat: by his own conscience, when, owing to a case of mistaken identity, another man is arrested in his place; and by the relentless investigations of the dogged Inspector Javert. It is not simply for himself that Valjean must stay free, however, for he has sworn to protect the baby daughter of Fantine, driven to prostitution by poverty.", null, "Les_miserables.jpg", true, false, 29.95m, "Les Miserables" },
                    { 8, "William S. Burroughs", 3, "Nightmarish and fiercely funny, William Burroughs' virtuoso, taboo-breaking masterpiece Naked Lunch follows Bill Lee through Interzone: a surreal, orgiastic wasteland of drugs, depravity, political plots, paranoia, sadistic medical experiments and endless, gnawing addiction. One of the most shocking novels ever written, Naked Lunch is a cultural landmark, now in a restored edition incorporating Burroughs' notes on the text, alternate drafts and outtakes from the original.", null, "Naked_lunch.jpg", true, false, 40.95m, "Naked Lunch" },
                    { 10, "Oscar Wilde", 1, "Tells the story of Dorian Gray, a beautiful yet corrupt man. When he wishes that a perfect portrait of himself would bear the signs of ageing in his place, the picture becomes his hideous secret, as it follows Dorian's own downward spiral into cruelty and depravity.", null, "Picture_of_dorian_gray.jpg", true, true, 39.95m, "The Picture of Dorian Grey" },
                    { 11, "Jane Austin", 3, "Pride and Prejudice, which opens with one of the most famous sentences in English Literature, is an ironic novel of manners. In it the garrulous and emptyheaded Mrs Bennet has only one aim - that of finding a good match for each of her five daughters. In this she is mocked by her cynical and indolent husband. With its wit, its social precision and, above all, its irresistible heroine, Pride and Prejudice has proved one of the most enduringly popular novels in the English language.", null, "Pride_and_prejudice.jpg", true, false, 35.95m, "Pride and prejudice" },
                    { 12, "Albert Camus", 2, "In The Outsider (1942), his classic existentialist novel, Camus explores the alienation of an individual who refuses to conform to social norms. Meursault, his anti-hero, will not lie. When his mother dies, he refuses to show his emotions simply to satisfy the expectations of others. And when he commits a random act of violence on a sun-drenched beach near Algiers, his lack of remorse compounds his guilt in the eyes of society and the law. Yet he is as much a victim as a criminal.", null, "The_Outsider.jpg", true, false, 36.95m, "The Outsider" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Fiction");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Tragedy");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Drama");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 4, "Satire" },
                    { 5, "Comedy" },
                    { 6, "Epic" },
                    { 7, "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsBookOfTheWeek", "Price", "Title" },
                values: new object[,]
                {
                    { 2, "George Orwell", 4, "When the downtrodden animals of Manor Farm overthrow their master Mr Jones and take over the farm themselves, they imagine it is the beginning of a life of freedom and equality. But gradually a cunning, ruthless elite among them, masterminded by the pigs Napoleon and Snowball, starts to take control. Soon the other animals discover that they are not all as equal as they thought, and find themselves hopelessly ensnared as one form of tyranny is replaced with another.", null, "Animal_Farm.jpg", true, false, 22.95m, "Animal Farm" },
                    { 3, "J.D. Salinger", 5, "The brilliant, funny, meaningful novel(The New Yorker) that established J. D. Salinger as a leading voice in American literature and that has instilled in millions of readers around the world a lifelong love of books. \"If you really want to hear about it, the first thing you'll probably want to know is where I was born, and what my lousy childhood was like, and how my parents were occupied and all before they had me, and all that David Copperfield kind of crap, but I don't feel like going into it, if you want to know the truth.\" The hero-narrator of The Catcher in the Rye is an ancient child of sixteen, a native New Yorker named Holden Caufield. Through circumstances that tend to preclude adult, secondhand description, he leaves his prep school in Pennsylvania and goes underground in New York City for three days.", null, "Catcher_in_the_rye.jpg", true, true, 42.95m, "The Catcher In The Rye" },
                    { 5, "F. Scott Fitzgerald", 5, "Through the narration of Nick Carraway, the reader is taken into the superficially glittering world of the mansions which lined the Long Island shore in the 1920s, to encounter Nick's cousin Daisy, her brash but wealthy husband Tom Buchanan, Jay Gatsby and the mystery that surrounds him.", null, "Great_Gatsby.jpg", true, true, 45.95m, "The Great Gatsby" },
                    { 4, "Fyodor Dostovjeskij", 6, "Crime and Punishment is one of the greatest and most readable novels ever written. From the beginning we are locked into the frenzied consciousness of Raskolnikov who, against his better instincts, is inexorably drawn to commit a brutal double murder. From that moment on, we share his conflicting feelings of self-loathing and pride, of contempt for and need of others, and of terrible despair and hope of redemption: and, in a remarkable transformation of the detective novel, we follow his agonised efforts to probe and confront both his own motives for, and the consequences of, his crime.", null, "Crime_and_Punishment.jpg", true, false, 24.95m, "Crime and Punishment" },
                    { 9, "Virginia Woolf", 7, "His longing for passion, adventure and fulfilment takes him out of his own time. Chasing a dream through the centuries, he bounds from Elizabethan England and imperial Turkey to the modern world. Will he find happiness with the exotic Russian Princess Sasha? Or is the dashing explorer Shelmerdine the ideal man? And what form will Orlando take on the journey - a nobleman, traveller, writer? Man or... woman?", null, "Orlando.jpg", true, true, 30.95m, "Orlando" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "Price" },
                values: new object[] { 1, "Great book!", "https://images-na.ssl-images-amazon.com/images/I/81Hs+IrRmwL.jpg", 12.95m });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Science fiction");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Thriller");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Literary");
        }
    }
}
