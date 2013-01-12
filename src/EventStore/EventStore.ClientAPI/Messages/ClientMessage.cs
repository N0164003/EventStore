//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ClientMessageDtos.proto
using System;
using System.ComponentModel;
using System.Collections.Generic;
using ProtoBuf;

namespace EventStore.ClientAPI.Messages
{
  public static partial class ClientMessage
  {
  [Serializable, ProtoContract(Name=@"NewEvent")]
  public partial class NewEvent
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_id", DataFormat = DataFormat.Default)]
    public readonly byte[] EventId;
  
    [ProtoMember(2, IsRequired = false, Name=@"event_type", DataFormat = DataFormat.Default)]
    public readonly string EventType;
  
    [ProtoMember(3, IsRequired = true, Name=@"is_json", DataFormat = DataFormat.Default)]
    public readonly bool IsJson;
  
    [ProtoMember(4, IsRequired = true, Name=@"data", DataFormat = DataFormat.Default)]
    public readonly byte[] Data;
  
    [ProtoMember(5, IsRequired = false, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    private NewEvent() {}
  
    public NewEvent(byte[] eventId, string eventType, bool isJson, byte[] data, byte[] metadata)
    {
        EventId = eventId;
        EventType = eventType;
        IsJson = isJson;
        Data = data;
        Metadata = metadata;
    }
  }
  
  [Serializable, ProtoContract(Name=@"EventRecord")]
  public partial class EventRecord
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"event_id", DataFormat = DataFormat.Default)]
    public readonly byte[] EventId;
  
    [ProtoMember(4, IsRequired = false, Name=@"event_type", DataFormat = DataFormat.Default)]
    public readonly string EventType;
  
    [ProtoMember(5, IsRequired = true, Name=@"data", DataFormat = DataFormat.Default)]
    public readonly byte[] Data;
  
    [ProtoMember(6, IsRequired = false, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    private EventRecord() {}
  
    public EventRecord(string eventStreamId, int eventNumber, byte[] eventId, string eventType, byte[] data, byte[] metadata)
    {
        EventStreamId = eventStreamId;
        EventNumber = eventNumber;
        EventId = eventId;
        EventType = eventType;
        Data = data;
        Metadata = metadata;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ResolvedIndexedEvent")]
  public partial class ResolvedIndexedEvent
  {
    [ProtoMember(1, IsRequired = true, Name=@"event", DataFormat = DataFormat.Default)]
    public readonly EventRecord Event;
  
    [ProtoMember(2, IsRequired = false, Name=@"link", DataFormat = DataFormat.Default)]
    public readonly EventRecord Link;
  
    private ResolvedIndexedEvent() {}
  
    public ResolvedIndexedEvent(EventRecord @event, EventRecord link)
    {
        Event = @event;
        Link = link;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ResolvedEvent")]
  public partial class ResolvedEvent
  {
    [ProtoMember(1, IsRequired = true, Name=@"event", DataFormat = DataFormat.Default)]
    public readonly EventRecord Event;
  
    [ProtoMember(2, IsRequired = false, Name=@"link", DataFormat = DataFormat.Default)]
    public readonly EventRecord Link;
  
    [ProtoMember(3, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(4, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    private ResolvedEvent() {}
  
    public ResolvedEvent(EventRecord @event, EventRecord link, long commitPosition, long preparePosition)
    {
        Event = @event;
        Link = link;
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"DeniedToRoute")]
  public partial class DeniedToRoute
  {
    [ProtoMember(1, IsRequired = true, Name=@"external_tcp_address", DataFormat = DataFormat.Default)]
    public readonly string ExternalTcpAddress;
  
    [ProtoMember(2, IsRequired = true, Name=@"external_tcp_port", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExternalTcpPort;
  
    [ProtoMember(3, IsRequired = true, Name=@"external_http_address", DataFormat = DataFormat.Default)]
    public readonly string ExternalHttpAddress;
  
    [ProtoMember(4, IsRequired = true, Name=@"external_http_port", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExternalHttpPort;
  
    private DeniedToRoute() {}
  
    public DeniedToRoute(string externalTcpAddress, int externalTcpPort, string externalHttpAddress, int externalHttpPort)
    {
        ExternalTcpAddress = externalTcpAddress;
        ExternalTcpPort = externalTcpPort;
        ExternalHttpAddress = externalHttpAddress;
        ExternalHttpPort = externalHttpPort;
    }
  }
  
  [Serializable, ProtoContract(Name=@"CreateStream")]
  public partial class CreateStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"request_id", DataFormat = DataFormat.Default)]
    public readonly byte[] RequestId;
  
    [ProtoMember(3, IsRequired = false, Name=@"metadata", DataFormat = DataFormat.Default)]
    public readonly byte[] Metadata;
  
    [ProtoMember(4, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    [ProtoMember(5, IsRequired = true, Name=@"is_json", DataFormat = DataFormat.Default)]
    public readonly bool IsJson;
  
    private CreateStream() {}
  
    public CreateStream(string eventStreamId, byte[] requestId, byte[] metadata, bool allowForwarding, bool isJson)
    {
        EventStreamId = eventStreamId;
        RequestId = requestId;
        Metadata = metadata;
        AllowForwarding = allowForwarding;
        IsJson = isJson;
    }
  }
  
  [Serializable, ProtoContract(Name=@"CreateStreamCompleted")]
  public partial class CreateStreamCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly OperationResult Result;
  
    [ProtoMember(3, IsRequired = false, Name=@"message", DataFormat = DataFormat.Default)]
    public readonly string Message;
  
    private CreateStreamCompleted() {}
  
    public CreateStreamCompleted(string eventStreamId, OperationResult result, string message)
    {
        EventStreamId = eventStreamId;
        Result = result;
        Message = message;
    }
  }
  
  [Serializable, ProtoContract(Name=@"WriteEvents")]
  public partial class WriteEvents
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"expected_version", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExpectedVersion;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly NewEvent[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private WriteEvents() {}
  
    public WriteEvents(string eventStreamId, int expectedVersion, NewEvent[] events, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        ExpectedVersion = expectedVersion;
        Events = events;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"WriteEventsCompleted")]
  public partial class WriteEventsCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly OperationResult Result;
  
    [ProtoMember(3, IsRequired = false, Name=@"message", DataFormat = DataFormat.Default)]
    public readonly string Message;
  
    [ProtoMember(4, IsRequired = true, Name=@"first_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int FirstEventNumber;
  
    private WriteEventsCompleted() {}
  
    public WriteEventsCompleted(string eventStreamId, OperationResult result, string message, int firstEventNumber)
    {
        EventStreamId = eventStreamId;
        Result = result;
        Message = message;
        FirstEventNumber = firstEventNumber;
    }
  }
  
  [Serializable, ProtoContract(Name=@"DeleteStream")]
  public partial class DeleteStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"expected_version", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExpectedVersion;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private DeleteStream() {}
  
    public DeleteStream(string eventStreamId, int expectedVersion, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        ExpectedVersion = expectedVersion;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"DeleteStreamCompleted")]
  public partial class DeleteStreamCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly OperationResult Result;
  
    [ProtoMember(3, IsRequired = false, Name=@"message", DataFormat = DataFormat.Default)]
    public readonly string Message;
  
    private DeleteStreamCompleted() {}
  
    public DeleteStreamCompleted(string eventStreamId, OperationResult result, string message)
    {
        EventStreamId = eventStreamId;
        Result = result;
        Message = message;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadEvent")]
  public partial class ReadEvent
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int EventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadEvent() {}
  
    public ReadEvent(string eventStreamId, int eventNumber, bool resolveLinkTos)
    {
        EventStreamId = eventStreamId;
        EventNumber = eventNumber;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadEventCompleted")]
  public partial class ReadEventCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly ReadEventCompleted.ReadEventResult Result;
  
    [ProtoMember(3, IsRequired = true, Name=@"event", DataFormat = DataFormat.Default)]
    public readonly ResolvedIndexedEvent Event;
  
    [ProtoContract(Name=@"ReadEventResult")]
    public enum ReadEventResult
    {
            
      [ProtoEnum(Name=@"Success", Value=0)]
      Success = 0,
            
      [ProtoEnum(Name=@"NotFound", Value=1)]
      NotFound = 1,
            
      [ProtoEnum(Name=@"NoStream", Value=2)]
      NoStream = 2,
            
      [ProtoEnum(Name=@"StreamDeleted", Value=3)]
      StreamDeleted = 3
    }
  
    private ReadEventCompleted() {}
  
    public ReadEventCompleted(string eventStreamId, ReadEventCompleted.ReadEventResult result, ResolvedIndexedEvent @event)
    {
        EventStreamId = eventStreamId;
        Result = result;
        Event = @event;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadStreamEvents")]
  public partial class ReadStreamEvents
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"from_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int FromEventNumber;
  
    [ProtoMember(3, IsRequired = true, Name=@"max_count", DataFormat = DataFormat.TwosComplement)]
    public readonly int MaxCount;
  
    [ProtoMember(4, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadStreamEvents() {}
  
    public ReadStreamEvents(string eventStreamId, int fromEventNumber, int maxCount, bool resolveLinkTos)
    {
        EventStreamId = eventStreamId;
        FromEventNumber = fromEventNumber;
        MaxCount = maxCount;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadStreamEventsCompleted")]
  public partial class ReadStreamEventsCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly ResolvedIndexedEvent[] Events;
  
    [ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly ReadStreamEventsCompleted.ReadStreamResult Result;
  
    [ProtoMember(4, IsRequired = true, Name=@"next_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int NextEventNumber;
  
    [ProtoMember(5, IsRequired = true, Name=@"last_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int LastEventNumber;
  
    [ProtoMember(6, IsRequired = true, Name=@"is_end_of_stream", DataFormat = DataFormat.Default)]
    public readonly bool IsEndOfStream;
  
    [ProtoMember(7, IsRequired = true, Name=@"last_vnode_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long LastVnodeCommitPosition;
  
    [ProtoContract(Name=@"ReadStreamResult")]
    public enum ReadStreamResult
    {
            
      [ProtoEnum(Name=@"Success", Value=0)]
      Success = 0,
            
      [ProtoEnum(Name=@"NoStream", Value=1)]
      NoStream = 1,
            
      [ProtoEnum(Name=@"StreamDeleted", Value=2)]
      StreamDeleted = 2,
            
      [ProtoEnum(Name=@"NotModified", Value=3)]
      NotModified = 3,
            
      [ProtoEnum(Name=@"Error", Value=4)]
      Error = 4
    }
  
    private ReadStreamEventsCompleted() {}
  
    public ReadStreamEventsCompleted(string eventStreamId, ResolvedIndexedEvent[] events, ReadStreamEventsCompleted.ReadStreamResult result, int nextEventNumber, int lastEventNumber, bool isEndOfStream, long lastVnodeCommitPosition)
    {
        EventStreamId = eventStreamId;
        Events = events;
        Result = result;
        NextEventNumber = nextEventNumber;
        LastEventNumber = lastEventNumber;
        IsEndOfStream = isEndOfStream;
        LastVnodeCommitPosition = lastVnodeCommitPosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadAllEvents")]
  public partial class ReadAllEvents
  {
    [ProtoMember(1, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(2, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    [ProtoMember(3, IsRequired = true, Name=@"max_count", DataFormat = DataFormat.TwosComplement)]
    public readonly int MaxCount;
  
    [ProtoMember(4, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private ReadAllEvents() {}
  
    public ReadAllEvents(long commitPosition, long preparePosition, int maxCount, bool resolveLinkTos)
    {
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
        MaxCount = maxCount;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"ReadAllEventsCompleted")]
  public partial class ReadAllEventsCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long CommitPosition;
  
    [ProtoMember(2, IsRequired = true, Name=@"prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long PreparePosition;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly ResolvedEvent[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"next_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long NextCommitPosition;
  
    [ProtoMember(5, IsRequired = true, Name=@"next_prepare_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long NextPreparePosition;
  
    private ReadAllEventsCompleted() {}
  
    public ReadAllEventsCompleted(long commitPosition, long preparePosition, ResolvedEvent[] events, long nextCommitPosition, long nextPreparePosition)
    {
        CommitPosition = commitPosition;
        PreparePosition = preparePosition;
        Events = events;
        NextCommitPosition = nextCommitPosition;
        NextPreparePosition = nextPreparePosition;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionStart")]
  public partial class TransactionStart
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"expected_version", DataFormat = DataFormat.TwosComplement)]
    public readonly int ExpectedVersion;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private TransactionStart() {}
  
    public TransactionStart(string eventStreamId, int expectedVersion, bool allowForwarding)
    {
        EventStreamId = eventStreamId;
        ExpectedVersion = expectedVersion;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionStartCompleted")]
  public partial class TransactionStartCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly OperationResult Result;
  
    [ProtoMember(4, IsRequired = false, Name=@"message", DataFormat = DataFormat.Default)]
    public readonly string Message;
  
    private TransactionStartCompleted() {}
  
    public TransactionStartCompleted(long transactionId, string eventStreamId, OperationResult result, string message)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        Result = result;
        Message = message;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionWrite")]
  public partial class TransactionWrite
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, Name=@"events", DataFormat = DataFormat.Default)]
    public readonly NewEvent[] Events;
  
    [ProtoMember(4, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private TransactionWrite() {}
  
    public TransactionWrite(long transactionId, string eventStreamId, NewEvent[] events, bool allowForwarding)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        Events = events;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionWriteCompleted")]
  public partial class TransactionWriteCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly OperationResult Result;
  
    [ProtoMember(4, IsRequired = false, Name=@"message", DataFormat = DataFormat.Default)]
    public readonly string Message;
  
    private TransactionWriteCompleted() {}
  
    public TransactionWriteCompleted(long transactionId, string eventStreamId, OperationResult result, string message)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        Result = result;
        Message = message;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionCommit")]
  public partial class TransactionCommit
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(3, IsRequired = true, Name=@"allow_forwarding", DataFormat = DataFormat.Default)]
    public readonly bool AllowForwarding;
  
    private TransactionCommit() {}
  
    public TransactionCommit(long transactionId, string eventStreamId, bool allowForwarding)
    {
        TransactionId = transactionId;
        EventStreamId = eventStreamId;
        AllowForwarding = allowForwarding;
    }
  }
  
  [Serializable, ProtoContract(Name=@"TransactionCommitCompleted")]
  public partial class TransactionCommitCompleted
  {
    [ProtoMember(1, IsRequired = true, Name=@"transaction_id", DataFormat = DataFormat.TwosComplement)]
    public readonly long TransactionId;
  
    [ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = DataFormat.TwosComplement)]
    public readonly OperationResult Result;
  
    [ProtoMember(3, IsRequired = false, Name=@"message", DataFormat = DataFormat.Default)]
    public readonly string Message;
  
    private TransactionCommitCompleted() {}
  
    public TransactionCommitCompleted(long transactionId, OperationResult result, string message)
    {
        TransactionId = transactionId;
        Result = result;
        Message = message;
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscribeToStream")]
  public partial class SubscribeToStream
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    [ProtoMember(2, IsRequired = true, Name=@"resolve_link_tos", DataFormat = DataFormat.Default)]
    public readonly bool ResolveLinkTos;
  
    private SubscribeToStream() {}
  
    public SubscribeToStream(string eventStreamId, bool resolveLinkTos)
    {
        EventStreamId = eventStreamId;
        ResolveLinkTos = resolveLinkTos;
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscriptionConfirmation")]
  public partial class SubscriptionConfirmation
  {
    [ProtoMember(1, IsRequired = true, Name=@"last_commit_position", DataFormat = DataFormat.TwosComplement)]
    public readonly long LastCommitPosition;
  
    [ProtoMember(2, IsRequired = false, Name=@"last_event_number", DataFormat = DataFormat.TwosComplement)]
    public readonly int? LastEventNumber;
  
    private SubscriptionConfirmation() {}
  
    public SubscriptionConfirmation(long lastCommitPosition, int? lastEventNumber)
    {
        LastCommitPosition = lastCommitPosition;
        LastEventNumber = lastEventNumber;
    }
  }
  
  [Serializable, ProtoContract(Name=@"StreamEventAppeared")]
  public partial class StreamEventAppeared
  {
    [ProtoMember(1, IsRequired = true, Name=@"event", DataFormat = DataFormat.Default)]
    public readonly ResolvedEvent Event;
  
    private StreamEventAppeared() {}
  
    public StreamEventAppeared(ResolvedEvent @event)
    {
        Event = @event;
    }
  }
  
  [Serializable, ProtoContract(Name=@"UnsubscribeFromStream")]
  public partial class UnsubscribeFromStream
  {
    public UnsubscribeFromStream()
    {
    }
  }
  
  [Serializable, ProtoContract(Name=@"SubscriptionDropped")]
  public partial class SubscriptionDropped
  {
    [ProtoMember(1, IsRequired = true, Name=@"event_stream_id", DataFormat = DataFormat.Default)]
    public readonly string EventStreamId;
  
    private SubscriptionDropped() {}
  
    public SubscriptionDropped(string eventStreamId)
    {
        EventStreamId = eventStreamId;
    }
  }
  
    [ProtoContract(Name=@"OperationResult")]
    public enum OperationResult
    {
            
      [ProtoEnum(Name=@"Success", Value=0)]
      Success = 0,
            
      [ProtoEnum(Name=@"PrepareTimeout", Value=1)]
      PrepareTimeout = 1,
            
      [ProtoEnum(Name=@"CommitTimeout", Value=2)]
      CommitTimeout = 2,
            
      [ProtoEnum(Name=@"ForwardTimeout", Value=3)]
      ForwardTimeout = 3,
            
      [ProtoEnum(Name=@"WrongExpectedVersion", Value=4)]
      WrongExpectedVersion = 4,
            
      [ProtoEnum(Name=@"StreamDeleted", Value=5)]
      StreamDeleted = 5,
            
      [ProtoEnum(Name=@"InvalidTransaction", Value=6)]
      InvalidTransaction = 6
    }
  
  }
}