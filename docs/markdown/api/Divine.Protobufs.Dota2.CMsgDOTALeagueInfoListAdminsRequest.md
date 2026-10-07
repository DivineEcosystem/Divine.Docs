# <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest"></a> Class CMsgDOTALeagueInfoListAdminsRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeagueInfoListAdminsRequest : IMessage<CMsgDOTALeagueInfoListAdminsRequest>, IEquatable<CMsgDOTALeagueInfoListAdminsRequest>, IDeepCloneable<CMsgDOTALeagueInfoListAdminsRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeagueInfoListAdminsRequest](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoListAdminsRequest.md)

#### Implements

IMessage<CMsgDOTALeagueInfoListAdminsRequest\>, 
[IEquatable<CMsgDOTALeagueInfoListAdminsRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeagueInfoListAdminsRequest\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgDOTALeagueInfoListAdminsRequest\>\(CMsgDOTALeagueInfoListAdminsRequest, params CMsgDOTALeagueInfoListAdminsRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest__ctor"></a> CMsgDOTALeagueInfoListAdminsRequest\(\)

```csharp
public CMsgDOTALeagueInfoListAdminsRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_"></a> CMsgDOTALeagueInfoListAdminsRequest\(CMsgDOTALeagueInfoListAdminsRequest\)

```csharp
public CMsgDOTALeagueInfoListAdminsRequest(CMsgDOTALeagueInfoListAdminsRequest other)
```

#### Parameters

`other` [CMsgDOTALeagueInfoListAdminsRequest](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoListAdminsRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeagueInfoListAdminsRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeagueInfoListAdminsRequest](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoListAdminsRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeagueInfoListAdminsRequest Clone()
```

#### Returns

 [CMsgDOTALeagueInfoListAdminsRequest](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoListAdminsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_"></a> Equals\(CMsgDOTALeagueInfoListAdminsRequest\)

```csharp
public bool Equals(CMsgDOTALeagueInfoListAdminsRequest other)
```

#### Parameters

`other` [CMsgDOTALeagueInfoListAdminsRequest](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoListAdminsRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_"></a> MergeFrom\(CMsgDOTALeagueInfoListAdminsRequest\)

```csharp
public void MergeFrom(CMsgDOTALeagueInfoListAdminsRequest other)
```

#### Parameters

`other` [CMsgDOTALeagueInfoListAdminsRequest](Divine.Protobufs.Dota2.CMsgDOTALeagueInfoListAdminsRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeagueInfoListAdminsRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

