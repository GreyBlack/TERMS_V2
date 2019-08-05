namespace TERMS_V2.Domain.Entity
{
    public class FollowInfo : AggregateRoot
    {
        public long EpisodeId { get; set; }

        public long UserId { get; set; }

        public FollowInfo(long episodeId, long userId)
        {
            EpisodeId = episodeId;
            UserId = userId;
        }
        public static FollowInfo FollowEpisode(Episode episode, BdUiUser userInfo)
        {
            return new FollowInfo(episode.EpisodeInfo.NMriEiMasterInfoId, userInfo.NBdUiUserId);
        }
    }
}