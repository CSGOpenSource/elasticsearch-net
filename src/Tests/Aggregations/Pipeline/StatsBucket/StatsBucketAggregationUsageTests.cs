﻿using System;
using FluentAssertions;
using Nest_5_2_0;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.MockData;

namespace Tests.Aggregations.Pipeline.StatsBucket
{
	public class StatsBucketAggregationUsageTests : AggregationUsageTestBase
	{
		public StatsBucketAggregationUsageTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override object ExpectJson => new
		{
			size = 0,
			aggs = new
			{
				projects_started_per_month = new
				{
					date_histogram = new
					{
						field = "startedOn",
						interval = "month",
					},
					aggs = new
					{
						commits = new
						{
							sum = new
							{
								field = "numberOfCommits"
							}
						}
					}
				},
				stats_commits_per_month = new
				{
					stats_bucket = new
					{
						buckets_path = "projects_started_per_month>commits"
					}
				}
			}
		};

		protected override Func<SearchDescriptor<Project>, ISearchRequest> Fluent => s => s
			.Size(0)
			.Aggregations(a => a
				.DateHistogram("projects_started_per_month", dh => dh
					.Field(p => p.StartedOn)
					.Interval(DateInterval.Month)
					.Aggregations(aa => aa
						.Sum("commits", sm => sm
							.Field(p => p.NumberOfCommits)
						)
					)
				)
				.StatsBucket("stats_commits_per_month", aaa => aaa
					.BucketsPath("projects_started_per_month>commits")
				)
			);

		protected override SearchRequest<Project> Initializer => new SearchRequest<Project>()
		{
			Size = 0,
			Aggregations = new DateHistogramAggregation("projects_started_per_month")
			{
				Field = "startedOn",
				Interval = DateInterval.Month,
				Aggregations = new SumAggregation("commits", "numberOfCommits")
			}
			&& new StatsBucketAggregation("stats_commits_per_month", "projects_started_per_month>commits")
		};

		protected override void ExpectResponse(ISearchResponse<Project> response)
		{
			response.ShouldBeValid();

			var projectsPerMonth = response.Aggs.DateHistogram("projects_started_per_month");
			projectsPerMonth.Should().NotBeNull();
			projectsPerMonth.Buckets.Should().NotBeNull();
			projectsPerMonth.Buckets.Count.Should().BeGreaterThan(0);

			var commitsStats = response.Aggs.StatsBucket("stats_commits_per_month");
			commitsStats.Should().NotBeNull();
			commitsStats.Average.Should().BeGreaterThan(0);
			commitsStats.Max.Should().BeGreaterThan(0);
			commitsStats.Min.Should().BeGreaterThan(0);
			commitsStats.Count.Should().BeGreaterThan(0);
			commitsStats.Sum.Should().BeGreaterThan(0);
		}
	}
}
