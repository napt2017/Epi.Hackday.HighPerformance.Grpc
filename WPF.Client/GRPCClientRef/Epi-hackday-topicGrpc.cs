// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: epi-hackday-topic.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRPC.Server {
  public static partial class EpiHackdayTopicService
  {
    static readonly string __ServiceName = "EpiHackdayTopic.EpiHackdayTopicService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GRPC.Server.Empty> __Marshaller_EpiHackdayTopic_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPC.Server.Empty.Parser));
    static readonly grpc::Marshaller<global::GRPC.Server.AllHackdayTopic> __Marshaller_EpiHackdayTopic_AllHackdayTopic = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPC.Server.AllHackdayTopic.Parser));
    static readonly grpc::Marshaller<global::GRPC.Server.HackdayTopic> __Marshaller_EpiHackdayTopic_HackdayTopic = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPC.Server.HackdayTopic.Parser));

    static readonly grpc::Method<global::GRPC.Server.Empty, global::GRPC.Server.AllHackdayTopic> __Method_GetAllTopic = new grpc::Method<global::GRPC.Server.Empty, global::GRPC.Server.AllHackdayTopic>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllTopic",
        __Marshaller_EpiHackdayTopic_Empty,
        __Marshaller_EpiHackdayTopic_AllHackdayTopic);

    static readonly grpc::Method<global::GRPC.Server.Empty, global::GRPC.Server.HackdayTopic> __Method_GetAllTopicStream = new grpc::Method<global::GRPC.Server.Empty, global::GRPC.Server.HackdayTopic>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllTopicStream",
        __Marshaller_EpiHackdayTopic_Empty,
        __Marshaller_EpiHackdayTopic_HackdayTopic);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPC.Server.EpiHackdayTopicReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for EpiHackdayTopicService</summary>
    public partial class EpiHackdayTopicServiceClient : grpc::ClientBase<EpiHackdayTopicServiceClient>
    {
      /// <summary>Creates a new client for EpiHackdayTopicService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public EpiHackdayTopicServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for EpiHackdayTopicService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public EpiHackdayTopicServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected EpiHackdayTopicServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected EpiHackdayTopicServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GRPC.Server.AllHackdayTopic GetAllTopic(global::GRPC.Server.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllTopic(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GRPC.Server.AllHackdayTopic GetAllTopic(global::GRPC.Server.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllTopic, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GRPC.Server.AllHackdayTopic> GetAllTopicAsync(global::GRPC.Server.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllTopicAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GRPC.Server.AllHackdayTopic> GetAllTopicAsync(global::GRPC.Server.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllTopic, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::GRPC.Server.HackdayTopic> GetAllTopicStream(global::GRPC.Server.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllTopicStream(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GRPC.Server.HackdayTopic> GetAllTopicStream(global::GRPC.Server.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAllTopicStream, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override EpiHackdayTopicServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EpiHackdayTopicServiceClient(configuration);
      }
    }

  }
}
#endregion
