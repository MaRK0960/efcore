// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.Sqlite.Internal;

namespace Microsoft.EntityFrameworkCore.Query;

#nullable disable

public class ManyToManyNoTrackingSplitQuerySqliteTest(ManyToManySplitQuerySqliteFixture fixture)
    : ManyToManyNoTrackingQueryRelationalTestBase<ManyToManySplitQuerySqliteFixture>(fixture)
{
    // Sqlite does not support Apply operations

}
