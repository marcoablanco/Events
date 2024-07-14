namespace Workshop.App.Features.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class PostModel
{
	[JsonPropertyName("_links")]
	public Links Links { get; set; }

	[JsonPropertyName("class_list")]
	public List<string> ClassList { get; set; }

	[JsonPropertyName("comment_status")]
	public string CommentStatus { get; set; }

	[JsonPropertyName("content")]
	public Content Content { get; set; }

	[JsonPropertyName("date")]
	public DateTime? Date { get; set; }

	[JsonPropertyName("date_gmt")]
	public DateTime? DateGmt { get; set; }

	[JsonPropertyName("excerpt")]
	public Excerpt Excerpt { get; set; }

	[JsonPropertyName("format")]
	public string Format { get; set; }

	[JsonPropertyName("link")]
	public string Link { get; set; }

	[JsonPropertyName("modified")]
	public DateTime? Modified { get; set; }

	[JsonPropertyName("modified_gmt")]
	public DateTime? ModifiedGmt { get; set; }

	[JsonPropertyName("ping_status")]
	public string PingStatus { get; set; }

	[JsonPropertyName("slug")]
	public string Slug { get; set; }

	[JsonPropertyName("status")]
	public string Status { get; set; }

	[JsonPropertyName("sticky")]
	public bool? Sticky { get; set; }

	[JsonPropertyName("template")]
	public string Template { get; set; }

	[JsonPropertyName("title")]
	public Title Title { get; set; }

	[JsonPropertyName("type")]
	public string Type { get; set; }
}


// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
public class About
{
	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class Author
{
	[JsonPropertyName("embeddable")]
	public bool? Embeddable { get; set; }

	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class Collection
{
	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class Content
{
	[JsonPropertyName("protected")]
	public bool? Protected { get; set; }

	[JsonPropertyName("rendered")]
	public string Rendered { get; set; }
}

public class Cury
{
	[JsonPropertyName("href")]
	public string Href { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("templated")]
	public bool? Templated { get; set; }
}

public class Excerpt
{
	[JsonPropertyName("protected")]
	public bool? Protected { get; set; }

	[JsonPropertyName("rendered")]
	public string Rendered { get; set; }
}

public class Guid
{
	[JsonPropertyName("rendered")]
	public string Rendered { get; set; }
}

public class ImageGeneratorSettings
{
	[JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }

	[JsonPropertyName("template")]
	public string Template { get; set; }
}

public class JetpackSocialOptions
{
	[JsonPropertyName("image_generator_settings")]
	public ImageGeneratorSettings ImageGeneratorSettings { get; set; }

	[JsonPropertyName("version")]
	public int? Version { get; set; }
}

public class Links
{
	[JsonPropertyName("about")]
	public List<About> About { get; set; }

	[JsonPropertyName("author")]
	public List<Author> Author { get; set; }

	[JsonPropertyName("collection")]
	public List<Collection> Collection { get; set; }

	[JsonPropertyName("curies")]
	public List<Cury> Curies { get; set; }

	[JsonPropertyName("predecessor-version")]
	public List<PredecessorVersion> PredecessorVersion { get; set; }

	[JsonPropertyName("replies")]
	public List<Reply> Replies { get; set; }

	[JsonPropertyName("self")]
	public List<Self> Self { get; set; }

	[JsonPropertyName("version-history")]
	public List<VersionHistory> VersionHistory { get; set; }

	[JsonPropertyName("wp:attachment")]
	public List<WpAttachment> WpAttachment { get; set; }

	[JsonPropertyName("wp:featuredmedia")]
	public List<WpFeaturedmedium> WpFeaturedmedia { get; set; }

	[JsonPropertyName("wp:term")]
	public List<WpTerm> WpTerm { get; set; }
}

public class Meta
{
	[JsonPropertyName("_jetpack_dont_email_post_to_subs")]
	public bool? JetpackDontEmailPostToSubs { get; set; }

	[JsonPropertyName("_jetpack_memberships_contains_paid_content")]
	public bool? JetpackMembershipsContainsPaidContent { get; set; }

	[JsonPropertyName("_jetpack_memberships_contains_paywalled_content")]
	public bool? JetpackMembershipsContainsPaywalledContent { get; set; }

	[JsonPropertyName("_jetpack_newsletter_access")]
	public string JetpackNewsletterAccess { get; set; }

	[JsonPropertyName("_jetpack_newsletter_tier_id")]
	public int? JetpackNewsletterTierId { get; set; }

	[JsonPropertyName("advanced_seo_description")]
	public string AdvancedSeoDescription { get; set; }

	[JsonPropertyName("footnotes")]
	public string Footnotes { get; set; }

	[JsonPropertyName("jetpack_post_was_ever_published")]
	public bool? JetpackPostWasEverPublished { get; set; }

	[JsonPropertyName("jetpack_publicize_feature_enabled")]
	public bool? JetpackPublicizeFeatureEnabled { get; set; }

	[JsonPropertyName("jetpack_publicize_message")]
	public string JetpackPublicizeMessage { get; set; }

	[JsonPropertyName("jetpack_seo_html_title")]
	public string JetpackSeoHtmlTitle { get; set; }

	[JsonPropertyName("jetpack_seo_noindex")]
	public bool? JetpackSeoNoindex { get; set; }

	[JsonPropertyName("jetpack_social_options")]
	public JetpackSocialOptions JetpackSocialOptions { get; set; }

	[JsonPropertyName("jetpack_social_post_already_shared")]
	public bool? JetpackSocialPostAlreadyShared { get; set; }
}

public class PredecessorVersion
{
	[JsonPropertyName("href")]
	public string Href { get; set; }

	[JsonPropertyName("id")]
	public int? Id { get; set; }
}

public class Reply
{
	[JsonPropertyName("embeddable")]
	public bool? Embeddable { get; set; }

	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class Root
{
}

public class Self
{
	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class Title
{
	[JsonPropertyName("rendered")]
	public string Rendered { get; set; }
}

public class VersionHistory
{
	[JsonPropertyName("count")]
	public int? Count { get; set; }

	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class WpAttachment
{
	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class WpFeaturedmedium
{
	[JsonPropertyName("embeddable")]
	public bool? Embeddable { get; set; }

	[JsonPropertyName("href")]
	public string Href { get; set; }
}

public class WpTerm
{
	[JsonPropertyName("embeddable")]
	public bool? Embeddable { get; set; }

	[JsonPropertyName("href")]
	public string Href { get; set; }

	[JsonPropertyName("taxonomy")]
	public string Taxonomy { get; set; }
}

