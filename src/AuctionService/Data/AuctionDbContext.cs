using AuctionService.Entities;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace AuctionService.Data;

public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<Auction> Auctions { get; set; }

    // This method is called by the runtime. Use this method to configure the database
    // Configures the database schema by adding entities for managing inbox, outbox messages, and outbox state.
    // THese entities are used to implement the Outbox pattern in MassTransit

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.AddInboxStateEntity();
        modelBuilder.AddOutboxMessageEntity();
        modelBuilder.AddOutboxStateEntity();
    }
}
